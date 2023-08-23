using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Logica {
    internal class EntradaDeDados2 {
        public static void Executar() {
            string nome;
            int quartos;
            double preco;

            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o último nome, idade e altura (mesma linha)");
            string[] pessoa = Console.ReadLine().Split(' ');
            string lastName = pessoa[0];
            int idade = int.Parse(pessoa[1]);
            double altura = double.Parse(pessoa[2].ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(pessoa[0]);
            Console.WriteLine(pessoa[1]);
            Console.WriteLine(pessoa[2].ToString(CultureInfo.InvariantCulture));

        }
    }
}
