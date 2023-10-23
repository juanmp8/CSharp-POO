using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.Entities
{
    internal class OperacoesBancarias
    {
        public static void Executar()
        {
            Conta acc = new Conta(1001, "Carlos", 0.0);
            ContaEmpresarial eacc = new ContaEmpresarial(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Conta acc1 = eacc;
            Conta acc2 = new ContaEmpresarial(1003, "Jorge", 0.0, 200.0);
            Conta acc3 = new ContaPoupanca(1004, "Joao", 0.0, 0.01);

            //DOWNCASTING
            ContaEmpresarial acc4 = (ContaEmpresarial)acc2;
            acc4.Emprestimo(100.0);
            if (acc3 is ContaEmpresarial) {
                //ContaEmpresarial acc5 = (ContaEmpresarial)acc3;
                ContaEmpresarial acc5 = acc3 as ContaEmpresarial;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }

            if (acc3 is ContaPoupanca) {
                //ContaPoupanca acc5 = (ContaPoupanca)acc3;
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.AtualizarSaldo();
                Console.WriteLine("Saldo Atualizado");
            }
        }

    }
}
