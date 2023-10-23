using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes {
    internal class Problema3 {
        public static void Executar() {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
