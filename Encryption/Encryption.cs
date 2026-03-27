using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption;

public abstract class Encryption
{
    public abstract byte[] Encrypt(byte[] data);
    public abstract byte[] Decrypt(byte[] cipherData);

    protected static byte[] GetEncryptionKey(IEncryptionOptions options)
    {
        // Return Empty Key If Password Is Null
        if (options.Password is null)
            return new byte[options.KeySize / 8];

        var saltBytes =
               options.PasswordDerivationSalt is null
               ? Array.Empty<byte>()
               : Encoding.UTF8.GetBytes(options.PasswordDerivationSalt);

        // Derive Key From Password and Salt
        return Rfc2898DeriveBytes.Pbkdf2(options.Password, saltBytes, 1, HashAlgorithmName.SHA256, options.KeySize / 8);
    }
}
