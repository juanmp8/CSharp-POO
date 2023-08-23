using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao5 {
    internal class ProblemaFinal {
        public static void Executar() {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nome, depositoInicial);
            } else {
                conta = new ContaBancaria(numero, nome);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double transacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(transacao);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            transacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(transacao);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
