using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes {
    internal class CotacaoDolar {
        public static void Executar() {
            Console.WriteLine("Digite o valor da cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de reais a serem convertidos: ");
            double qnt = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double result = CMoeda.ConversorDeMoeda(cotacao, qnt);
            Console.WriteLine("O valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
