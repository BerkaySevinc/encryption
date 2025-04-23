using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Encryption;


public class AesEncryptionOptions : IEncryptionOptions
{
    public bool UseIV { get; set; }

    public int KeySize { get; set; } = 256;
    public int BlockSize { get; } = 128;

    public PaddingMode Padding { get; set; } = PaddingMode.PKCS7;

    public string? Password { get; set; }
    public string? PasswordDerivationSalt { get; set; }
}
