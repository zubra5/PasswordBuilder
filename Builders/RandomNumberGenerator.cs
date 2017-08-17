using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordBuilder.Builders
{
    class RandomNumberGenerator : PasswordGenerator
    {
        private const int maxNumber = 9;

        private const int minNumber = 0;

        private const int lengthLoop = 5;

        public override void GetHash()
        {
            HashAlgorithm algorithm = MD5.Create();

            byte[] arrBytes = Encoding.UTF8.GetBytes(Pass);

            byte[] hash = algorithm.ComputeHash(arrBytes);

            Pass= BitConverter.ToString(hash).Replace("-", String.Empty);
        }

        public override void GetNewString()
        {

            StringBuilder sBuilder = new StringBuilder();
            Random rnd = new Random();
            for (int i = 1; i <= lengthLoop; i++)
            {
                sBuilder.Append(rnd.Next(minNumber, maxNumber).ToString());
            }

            Pass=sBuilder.ToString();
        }

    }
}
