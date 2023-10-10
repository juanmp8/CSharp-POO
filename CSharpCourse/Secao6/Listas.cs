using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6 {
    internal class Listas {
        public static void Executar() {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Carlos");
            list.Add("Juan");
            list.Insert(2, "Jorge");

            foreach (var item in list) {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'J');
            Console.WriteLine("First 'J': " + s1);

            string s2 = list.FindLast(x => x[0] == 'J');
            Console.WriteLine("Last 'J': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'J');
            Console.WriteLine("First position 'J': " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'J');
            Console.WriteLine("First position 'J': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------------------");
            foreach(var item in list2) {
                Console.WriteLine(item);
            }

            //list.Remove("Carlos");
            //list.RemoveAt(0);
            list.RemoveRange(0, 2);
            Console.WriteLine("------------------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'J');
            Console.WriteLine("------------------------");
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}
