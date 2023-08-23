using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes {
    internal class IntroPOO {
        public static void Executar() {
            Pessoa p1, p2;
            Funcionario f1, f2;
            double media;

            p1 = new Pessoa();
            p2 = new Pessoa();
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Digite os dados da primeira pessoa");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os dados da segunda pessoa");
            Console.WriteLine("Nome:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade> p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("Digite os dados do primeiro funcionário:");
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite os dados do segundo funcionário:");
            Console.WriteLine("Nome:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário:");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario+ f2.Salario) / 2;

            Console.WriteLine("Salário médio = $" +media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}