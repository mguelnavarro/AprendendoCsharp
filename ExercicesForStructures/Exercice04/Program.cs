//Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
//começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
//exemplo.
using System;

namespace ExercicesForStructures{
    class Program{
        public static void Main(){
            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++){
                Console.Write(i+ " ");
                Console.Write(Math.Pow(i, 2)+" ");
                Console.WriteLine(Math.Pow(i, 3)+" ");
            }
        }
    }
}