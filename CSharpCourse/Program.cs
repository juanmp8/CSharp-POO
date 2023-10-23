﻿using System;
using System.Collections.Generic;
using CSharpCourse.Classes;
using CSharpCourse.Logica;
using CSharpCourse.Secao10.Entities;
using CSharpCourse.Secao5;
using CSharpCourse.Secao6;
using CSharpCourse.Secao6.Ex_List;
using CSharpCourse.Secao6.Ex_Matriz;
using CSharpCourse.Secao7;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Seção 3 | Saída de Dados", SaidaDeDados.Executar},
                {"Seção 3 | Entrada de Dados 2", EntradaDeDados2.Executar},
                {"Seção 4 | Problema 1 - Introdução a POO", IntroPOO.Executar},
                {"Seção 4 | Problema Produto - Introdução a POO", Problema2.Executar},
                {"Seção 4 | Problema Retângulo - Introdução a POO", Problema3.Executar},
                {"Seção 4 | Problema Funcionário - Introdução a POO", Problema4.Executar},
                {"Seção 4 | Problema Aluno - Introdução a POO", Problema5.Executar},
                {"Seção 4 | Cotação Dolar - Membros Estáticos", CotacaoDolar.Executar},
                {"Seção 5 | Construtores e Sobrecarga", Construtores.Executar},
                {"Seção 5 | Encapsulamento e Properties", Encapsulamento.Executar},
                {"Seção 5 | Problema Final - Conta Bancaria", ProblemaFinal.Executar},
                {"Seção 6 | Vetores 1", Vetores1.Executar},
                {"Seção 6 | Vetores 2", Vetores2.Executar},
                {"Seção 6 | Params", Params.Executar},
                {"Seção 6 | Foreach", Foreach.Executar},
                {"Seção 6 | List", Listas.Executar},
                {"Seção 6 | Exercício de fixação List", Fixacao.Executar},
                {"Seção 6 | Matriz", Matriz.Executar},
                {"Seção 6 | Exercício de fixação Matriz", FixMatriz.Executar},
                {"Seção 7 | Switch Case", SwitchCase.Executar},
                {"Seção 10 | Herança e Polimorfismo", OperacoesBancarias.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}