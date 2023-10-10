using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6 {
    internal class Foreach {
        public static void Executar() {
            string[] nomes = new string[] { "Maria", "Alex", "Bob" };
            int[] numbers = new int[] { 1, 4, 5, 6 };
            foreach (string obj in nomes) {
                Console.WriteLine(obj);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
