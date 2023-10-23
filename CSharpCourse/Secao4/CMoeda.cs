using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Classes {
    internal class CMoeda {

        public static double IOF = 0.06;

        public static double ConversorDeMoeda(double cotacao, double quantidade) {
            double total = cotacao * quantidade;
            return total + total * IOF;
        }
    }
}
