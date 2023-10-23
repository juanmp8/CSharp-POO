using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes {
    internal class Problema4 {
        public static void Executar() {
            Funcionario f;
            f = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário: ");
            Console.WriteLine("Nome: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f.Nome}, ${f.SalarioLiquido()}");
            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine());
            f.AumentarSalario(porc);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f.Nome}, ${f.SalarioLiquido()}");
        }
    }
}
    