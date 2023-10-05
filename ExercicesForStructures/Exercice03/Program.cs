//Ler um número inteiro N e calcular todos os seus divisores.
using System;

namespace ExercicesForStructures{
    class Program{
        public static void Main(){
            Console.Write("Digite um número, para descobrir seus divisor: ");
            int number1 = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= number1 ; i++){
                int divisor = number1 % i ;

                if(divisor == 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}