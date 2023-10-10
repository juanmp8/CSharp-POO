using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6.Ex_List {
    internal class Fixacao {
        public static void Executar() {



            Console.WriteLine("Digite a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.WriteLine("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Digite o Id do funcionário que receberá o aumento: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario funcionario = funcionarios.Find(x => x.Id == searchId);

            if (searchId != null) {
                Console.WriteLine("Digite a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario.AumentarSalario(porcentagem);
            } else {
                Console.WriteLine("Funcionário não cadastrado");
            }

            Console.WriteLine("Lista atualizada: ");
            foreach (var obj in funcionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
