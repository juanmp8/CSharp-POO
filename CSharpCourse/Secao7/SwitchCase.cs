﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao7 {
    internal class SwitchCase {
        public static void Executar() {
            Console.WriteLine("Digite um número de 1 a 7:");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x) {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break; 
                case 4:
                    day = "Wednesday";
                    break; 
                case 5:
                    day = "Thursday";
                    break; 
                case 6: 
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}
