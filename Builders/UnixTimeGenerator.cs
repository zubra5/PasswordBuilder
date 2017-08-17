using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordBuilder.Builders
{
    class UnixTimeGenerator : PasswordGenerator
    {
        public override void GetHash()
        {
            var sha = new System.Security.Cryptography.SHA256Managed();

            byte[] textData = System.Text.Encoding.UTF8.GetBytes(Pass);

            byte[] hash = sha.ComputeHash(textData);

            Pass= BitConverter.ToString(hash).Replace("-", String.Empty);           
        }

        public override void GetNewString()
        {
            long newNumber = DateTime.Now.Ticks;

            Pass = Convert.ToString(newNumber);            
        }
    
    }
}
