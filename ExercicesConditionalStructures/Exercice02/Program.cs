//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
using System;

namespace ExercicesCondionalStructures{
    class Program{
        public static void Main(){
            double number;
            Console.Write("Digite um número para saber se é par ou impar: ");
            number = double.Parse(Console.ReadLine());

            if(number % 2 == 0){
                Console.WriteLine($"O número {number} é par.");
            }else{
                Console.WriteLine($"O número {number} é impar.");
            }
        }

    }
}