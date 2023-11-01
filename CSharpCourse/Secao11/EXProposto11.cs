using CSharpCourse.Secao11.Entities;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCourse.Secao11.Entities.Exceptions;

namespace CSharpCourse.Secao11
{
    internal class EXProposto11
    {
        public static void Executar()
        {
            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account conta = new Account(number, holder, balance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Withdraw(withdraw);
                Console.Write("New balance: " + conta.Balance);

            } catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
