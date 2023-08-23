using CSharpCourse.Secao5;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6 {
    internal class Vetores2 {
        public static void Executar() {
            int n;

            Console.WriteLine("Digite o número de produtos:");
            n = int.Parse(Console.ReadLine());
            Product[] product = new Product[n];
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite o nome do {i+1} produto:");
                string name = Console.ReadLine();
                Console.WriteLine($"Digite o preço do {i+1} produto:");
                double price = double.Parse(Console.ReadLine());
                product[i] = new Product (name, price);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += product[i].Preco;
            }
            double media = sum / n;
            Console.WriteLine($"O preço médio dos produtos é: ${media.ToString("F2")}");
        }
    }
}
