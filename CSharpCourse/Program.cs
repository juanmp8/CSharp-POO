using System;
using System.Collections.Generic;
using CSharpCourse.Classes;
using CSharpCourse.Logica;
using CSharpCourse.Secao5;
using CSharpCourse.Secao6;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Logica | Saída de Dados", SaidaDeDados.Executar},
                {"Logica | Entrada de Dados 2", EntradaDeDados2.Executar},
                {"Classes | Problema 1 - Introdução a POO", IntroPOO.Executar},
                {"Classes | Problema Produto - Introdução a POO", Problema2.Executar},
                {"Classes | Problema Retângulo - Introdução a POO", Problema3.Executar},
                {"Classes | Problema Funcionário - Introdução a POO", Problema4.Executar},
                {"Classes | Problema Aluno - Introdução a POO", Problema5.Executar},
                {"Classes | Cotação Dolar - Membros Estáticos", CotacaoDolar.Executar},
                {"Seção 5 | Construtores e Sobrecarga", Construtores.Executar},
                {"Seção 5 | Encapsulamento e Properties", Encapsulamento.Executar},
                {"Seção 5 | Problema Final - Conta Bancaria", ProblemaFinal.Executar},
                {"Seção 6 | Vetores 1", Vetores1.Executar},
                {"Seção 6 | Vetores 2", Vetores2.Executar},
                {"Seção 6 | Params", Params.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}