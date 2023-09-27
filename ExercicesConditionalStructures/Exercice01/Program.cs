//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
using System;

namespace ExercicesCondionalStructures{
    class Program{
        public static void Main(){
            double number;
            
            Console.Write("Digite um número para saber se ele é negativo ou não: ");
            number = double.Parse(Console.ReadLine());
            
            if(number < 0){
                Console.WriteLine($"O número {number} é negativo.");
            }else if(number == 0){
             Console.WriteLine($"O número {number} é neutro.");
            }else{
             Console.WriteLine($"O número {number} é positivo.");
            }
            
        }
    }
}