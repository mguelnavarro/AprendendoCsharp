//Você deve fazer um programa que leia um valor qualquer 
//apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. 
//Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
using System;

namespace ExercicesCondionalStructures{
    class Program{
        public static void Main(string[] args){
        Console.Write("Digite o valor do intervalo:");
        int interval = int.Parse(Console.ReadLine());
        
        if(interval >= 0 && interval <= 25){
            Console.Write("Intervalo [0,25]");

        }else if(interval > 25 && interval <= 50){
            Console.Write("Intervalo [25,50]");
        }else if(interval > 50 && interval <= 75){
            Console.Write("Intervalo [50,75]");
        }else if(interval > 75 && interval <= 100){
            Console.Write("Intervalo [75,100]");
        }else{
            Console.Write("Fora de intervalo.");
        }

        }

    }
}