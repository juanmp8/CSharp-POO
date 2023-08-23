using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes
{
    internal class Problema2
    {
        public static void Executar() {
            Produto p1;
            p1 = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque:");
            p1.Quantidade = int.Parse(Console.ReadLine());
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
