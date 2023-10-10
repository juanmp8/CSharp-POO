using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6 {
    internal class Params {
        public static void Executar() {
            int s1 = Calculator.Sum(2, 4, 5, 7, 9, 1);
            int s2 = Calculator.Sum(2, 4, 5, 3, 2, 22);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int t1 = 10;
            Calculator.Triple(ref t1);
            Console.WriteLine(t1);

            int t2 = 20;
            int result;
            Calculator.Triple(t2, out result);
            Console.WriteLine(result);
        }
    }
}
