using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao5 {
    internal class Encapsulamento {
        public static void Executar() {
            #region Getters e Setters
            /*Console.WriteLine("Digite as informações do marca para venda: ");
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Concessionaria c = new Concessionaria(marca, modelo, preco);
            Console.WriteLine(c.Getmarca());
            Console.WriteLine(c.GetModelo());
            Console.WriteLine(c.GetPreco());
            Console.WriteLine();
            Console.WriteLine("Digite o novo preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.SetPreco(preco);
            Console.WriteLine(c.GetPreco());*/
            #endregion
            #region Properties
            Concessionaria c = new Concessionaria("Ford", "Focus", 2000);
            Console.WriteLine(c.Marca);
            c.Marca = "Chevrolet";
            Console.WriteLine(c.Marca);
            #endregion
        }
    }
}
