using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.Entities {
    internal class ContaPoupanca : Conta{
        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string proprietario, double saldo, double taxaJuros) : base(numero, proprietario, saldo) {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo() {
            Saldo = Saldo * TaxaJuros;
        }

        public override void Saque(double quantia) {
            base.Saque(quantia);
            Saldo -= 2.0;
        }
    }
}
