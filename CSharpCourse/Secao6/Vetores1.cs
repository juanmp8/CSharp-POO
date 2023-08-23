using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6 {
    internal class Vetores1 {
        public static void Executar() {
            int n;
            double soma= 0.0;
            Console.WriteLine("Digite um número de pessoas:");
            n = int.Parse(Console.ReadLine());
            double[] alturas = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Digite a altura da {i+1} pessoa:");
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            }

            for (int i = 0; i < n; i++) {
                soma += alturas[i];
            }

            soma = soma / n;

            Console.WriteLine("A média das alturas foi de: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
