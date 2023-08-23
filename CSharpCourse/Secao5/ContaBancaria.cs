using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao5 {
    internal class ContaBancaria {
        
        public int Numero{ get; private set; }
        public string Nome{ get; set; }
        public double Saldo { get; private set; }   

        public ContaBancaria(int numero, string nome) {
            Numero = numero;
            Nome = nome;    
        }

        public ContaBancaria(int numero, string nome, double depositoInicial) : this(numero, nome){
            Deposito(depositoInicial);
        }

        override public string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;       
        }

        public void Saque(double saque) {
            Saldo -= saque;
            Saldo -= 5;
        }

    }
}
