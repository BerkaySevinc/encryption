# Bekos.Encryption

**Bekos.Encryption** is a library written in C#.
Provides AES encryption and decryption with support for password-based key derivation and optional IV generation.

Core logic is separated into a reusable library, with a demo application included for interaction and testing.

> ⚠️ **Cryptography Notice:** This library implements AES encryption. Ensure it is used responsibly and in compliance with applicable laws and regulations.

## Features
- **AES Encryption** — encrypt and decrypt data using AES with configurable key size, block size, and padding mode.
- **Password-based key derivation** — derives encryption keys from a password and optional salt using PBKDF2 (SHA-256).
- **IV support** — optionally generates and prepends a random IV per encryption for increased security.
- **Reconfigurable encryptor** — encryption options can be updated at runtime via `ConfigureEncryption`.

## Details
- Written in **C#**.
- Uses **Windows Forms** for the demo GUI.
- Structured as two projects: `Bekos.Encryption` (class library) and `Bekos.Encryption.Demo` (WinForms demo app).

## Usage
```csharp
var options = new AesEncryptionOptions
{
    Password = "my-password",
    PasswordDerivationSalt = "my-salt",
    UseIV = true
};

using var aes = new AesEncryption(options);

byte[] cipher = aes.Encrypt(Encoding.UTF8.GetBytes("hello world"));
byte[] plain  = aes.Decrypt(cipher);
```

## Media
![Demo](media/Video%201.gif)
