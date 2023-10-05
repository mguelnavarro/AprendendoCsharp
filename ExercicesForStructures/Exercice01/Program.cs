// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
// X, se for o caso.
using System;

namespace ExercicesForStructures{
    class Program{
        public static void Main(){
           
           Console.Write("Digite um numero, para descobrir quais sao seus antecessores impares: ");
           int numbers = int.Parse(Console.ReadLine());
           for(int i = 1; i <= numbers; i++){
            if(i % 2 == 1){
                Console.Write(i + " ");
            }
           }

        }
    }
}