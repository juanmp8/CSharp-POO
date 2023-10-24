using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpCourse.Secao10.Abstracao.EX2 {
    internal class EXFixAbstract {
        public static void Executar() {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            double totalTaxes = 0;
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                } else if (ch == 'c') {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, annualIncome, numberOfEmployees));
                } else {
                    Console.WriteLine("Invalid Value");
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list) {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
