using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse.Secao6.Ex_Matriz {
    internal class FixMatriz {
        //Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições.
        //Em seguida ler um número inteiro X que pertence a matriz. Para cada ocorrência de X, mostrar os valores à esquerda, cima, à direita e abaixo de X, quando houber, conforme exemplo.
        public static void Executar() {
            Console.WriteLine("Digite o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite um número para pesquisar na matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (x == mat[i,j]) {
                        Console.WriteLine($"Posição: {i},{j}");
                        if (j > 0) {
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                        }
                        if (j < n - 1) {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }
                        if (i > 0) {
                            Console.WriteLine($"Cima: {mat[i - 1, j]}");
                        }
                        if (i < m - 1) {
                            Console.WriteLine($"Baixo: {mat[i + 1, j]}");
                        }

                    }
                }
            }

        }
    }
}
