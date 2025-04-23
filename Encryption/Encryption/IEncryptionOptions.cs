using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption;

public interface IEncryptionOptions
{
    public bool UseIV { get; }

    public int KeySize { get; }
    public int BlockSize { get; }

    public string? Password { get; set; }
    public string? PasswordDerivationSalt { get; set; }
}
