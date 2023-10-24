using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.HerancaPolimorfismo {
    internal class ContaEmpresarial : Conta{
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresarial() { }

        public ContaEmpresarial(int numero, string proprietario, double saldo, double limiteEmprestimo) : base(numero, proprietario, saldo) {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia) {
            if (quantia <= LimiteEmprestimo) { 
                Saldo += quantia;
            }
        }
    }
}
