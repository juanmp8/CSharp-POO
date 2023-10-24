using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.HerancaPolimorfismo {
    internal class Sobreposicao {
        public static void Executar() {
            Conta acc1 = new Conta(1001, "Carlos", 500.0);
            Conta acc2 = new ContaPoupanca(1002, "Ana", 500.0, 0.01);

            acc1.Saque(10.0);
            acc2.Saque(10.0);

            Console.WriteLine(acc1.Saldo);
            Console.WriteLine(acc2.Saldo);
        }
    }
}
