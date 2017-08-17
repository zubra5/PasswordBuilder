using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordBuilder.Builders;

namespace PasswordBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
           PasswordGenerator generator = new RandomNumberGenerator();
           // PasswordGenerator generator = new UnixTimeGenerator();

            PasswordSupplier supplier = new PasswordSupplier(generator);

            string pass = supplier.GetNewPassword();

            Console.WriteLine($"New password {pass}");

            Console.ReadKey();
        }
    }
}
