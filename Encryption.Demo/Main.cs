

using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

using Encryption;


namespace AesEncryptionDemo;


public partial class Main : Form
{

    public Main()
    {
        CheckForIllegalCrossThreadCalls = false;

        InitializeComponent();
    }


    byte[]? cipherData;
    string plainText = string.Empty;
    AesEncryption encryptor = new();
    private void btnSend_Click(object sender, EventArgs e)
    {
        tbxDecryptorPlainText.Text = string.Empty;

        plainText = tbxEncryptorMessage.Text;

        if (string.IsNullOrEmpty(plainText))
        {
            cipherData = null;

            tbxEncryptorCipherText.Text = string.Empty;
            tbxDecryptorCipherText.Text = string.Empty;

            return;
        }

        var encryptionOptions = new AesEncryptionOptions()
        {
            Password = tbxEncryptorPass.Text,
            PasswordDerivationSalt = tbxEncryptorSalt.Text,
            UseIV = cbxEncryptorUseIV.Checked,
        };

        encryptor.ConfigureEncryption(encryptionOptions);

        var data = Encoding.UTF8.GetBytes(plainText);
        cipherData = encryptor.Encrypt(data);

        tbxEncryptorCipherText.Text = Encoding.UTF8.GetString(cipherData);
        tbxDecryptorCipherText.Text = tbxEncryptorCipherText.Text;
    }



    AesEncryption decryptor = new();
    private void btnDecrypt_Click(object sender, EventArgs e)
    {
        if (cipherData is null)
        {
            tbxDecryptorPlainText.Text = string.Empty;
            return;
        }

        var decryptionOptions = new AesEncryptionOptions()
        {
            Password = tbxDecryptorPass.Text,
            PasswordDerivationSalt = tbxDecryptorSalt.Text,
            UseIV = cbxDecryptorUseIV.Checked,
        };

        decryptor.ConfigureEncryption(decryptionOptions);

        byte[] data = decryptor.Decrypt(cipherData);
        string plainText = Encoding.UTF8.GetString(data);

        tbxDecryptorPlainText.Text = plainText;
    }
}