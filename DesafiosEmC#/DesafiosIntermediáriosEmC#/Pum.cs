//Desafio
//Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

//Entrada
//O arquivo de entrada contém um número inteiro positivo N.

//Saída
//Imprima a saída conforme o exemplo fornecido.

//EM FASE DE CONCLUSÃO
//EM FASE DE CONCLUSÃO
//EM FASE DE CONCLUSÃO
//EM FASE DE CONCLUSÃO

using System;

namespace TESTE {
    class Program {
        static void Main(string[] args) {
        
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N*4; i++) {
             if (i % 4 != 0) {
                Console.Write(i + " ");
              } else {
                Console.Write("PUM\n");
              }
            }
        }
    }
}