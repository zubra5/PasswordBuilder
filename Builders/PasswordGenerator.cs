using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordBuilder.Builders
{
    abstract class PasswordGenerator
    {
        protected string Pass { get; set; }

        protected static int LengthPass => lengthPass;

        private const int lengthPass = 10;
        public abstract void GetNewString();

        public abstract void GetHash();

        public string GetResult() {
            return Pass.Substring(0, LengthPass);
        }
    }
}
