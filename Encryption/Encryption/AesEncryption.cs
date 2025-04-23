using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Encryption;



public class AesEncryption : Encryption, IDisposable
{

    public AesEncryption(AesEncryptionOptions options) =>
        ConfigureEncryption(options);
    public AesEncryption() : this(new AesEncryptionOptions()) { }


    private readonly Aes aes = Aes.Create();
    private ICryptoTransform? aesEncryptor;
    private ICryptoTransform? aesDecryptor;

    private int ivLength;

    private Func<byte[], byte[]> Encryptor;
    private Func<byte[], byte[]> Decryptor;

    // Configurations
    [MemberNotNull(nameof(Encryptor), nameof(Decryptor))]
    public void ConfigureEncryption(AesEncryptionOptions options)
    {
        aes.KeySize = options.KeySize;
        aes.BlockSize = options.BlockSize;
        ivLength = options.BlockSize / 8;

        aes.Padding = options.Padding;

        aes.Key = GetEncryptionKey(options);
        aes.IV = new byte[ivLength];

        // Dispose Old Encryptors
        aesEncryptor?.Dispose();
        aesDecryptor?.Dispose();

        // Assign Encryptors
        if (options.UseIV)
        {
            Encryptor = EncryptWithIV;
            Decryptor = DecryptWithIV;
        }
        // Recreate Ready-Constant Encryptors If IV Disabled
        else
        {
            aesEncryptor = aes.CreateEncryptor();
            aesDecryptor = aes.CreateDecryptor();

            Encryptor = EncryptWithoutIV;
            Decryptor = DecryptWithoutIV;
        }
    }


    public override byte[] Encrypt(byte[] data) => Encryptor.Invoke(data);
    public override byte[] Decrypt(byte[] cipherData) => Decryptor.Invoke(cipherData);



    private readonly MemoryStream memoryStream = new();
    private byte[] EncryptWithoutIV(byte[] data)
    {
        using var cryptoStream = new CryptoStream(memoryStream, aesEncryptor!, CryptoStreamMode.Write, true);

        cryptoStream.Write(data);
        cryptoStream.FlushFinalBlock();

        var result = memoryStream.ToArray();

        memoryStream.SetLength(0);

        return result;
    }
    private byte[] EncryptWithIV(byte[] data)
    {
        aes.GenerateIV();

        memoryStream.Write(aes.IV);

        using var aesEncryptor = aes.CreateEncryptor();
        using var cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write, true);

        cryptoStream.Write(data);
        cryptoStream.FlushFinalBlock();

        var result = memoryStream.ToArray();

        memoryStream.SetLength(0);

        return result;
    }

    private byte[] DecryptWithoutIV(byte[] data)
    {
        using var cryptoStream = new CryptoStream(memoryStream, aesDecryptor!, CryptoStreamMode.Write, true);

        cryptoStream.Write(data);
        cryptoStream.FlushFinalBlock();

        var result = memoryStream.ToArray();

        memoryStream.SetLength(0);

        return result;
    }
    private byte[] DecryptWithIV(byte[] data)
    {
        var iv = new byte[ivLength];
        Array.Copy(data, 0, iv, 0, ivLength);

        using var aesDecryptor = aes.CreateDecryptor(aes.Key, iv);
        using var cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write, true);

        cryptoStream.Write(data, ivLength, data.Length - ivLength);
        cryptoStream.FlushFinalBlock();

        var result = memoryStream.ToArray();

        memoryStream.SetLength(0);

        return result;
    }


    public void Dispose()
    {
        aesEncryptor?.Dispose();
        aesDecryptor?.Dispose();

        aes.Dispose();

        memoryStream.Dispose();
    }
}
