using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordBuilder.Builders;

namespace PasswordBuilder
{
    class PasswordSupplier
    {
        private PasswordGenerator Generator { get; set; }

        public PasswordSupplier(PasswordGenerator generator) {
            Generator = generator;
        }

        public string GetNewPassword() {
            String password = String.Empty;

            Generator.GetNewString();

            Generator.GetHash();

            password = Generator.GetResult();

            return password;
        }
    }
}
