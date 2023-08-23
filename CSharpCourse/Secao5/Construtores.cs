using CSharpCourse.Classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao5 {
    internal class Construtores {
        public static void Executar() {
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Product p1 = new Product(nome, preco);
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p1);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);

        }
    }
}
