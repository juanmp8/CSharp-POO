using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao10.HerancaPolimorfismo {
    internal class Conta {
        public int Numero { get; private set; }
        public string Proprietario { get; private set; }
        public double Saldo { get; protected set; }

        public Conta() { }

        public Conta(int numero, string proprietario, double saldo) {
            Numero = numero;
            Proprietario = proprietario;
            Saldo = saldo;
        }

        public virtual void Saque(double quantia) {
            Saldo -= quantia + 5.0;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }
    }
}
