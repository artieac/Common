using System;
using System.Collections.Generic;
using System.Text;

namespace PucksAndProgramming.Common.Encryption
{
    public class EnvironmentAESConfiguration : AESConfiguration
    {
        public EnvironmentAESConfiguration()
        {
            this.EncryptionKey = Environment.GetEnvironmentVariable("AES_ENCRYPTION_KEY");
            this.Salt = Environment.GetEnvironmentVariable("AES_ENCRYPTION_SALT");
        }
    }
}
