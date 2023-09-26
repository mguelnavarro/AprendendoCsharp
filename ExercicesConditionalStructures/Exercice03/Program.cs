//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
using System;

namespace ExercicesCondionalStructures{
    class Program{
        static void Main(){
            double startHour,endHour;
            double duration;
            string[] values = Console.ReadLine().Split(" ");
            
            startHour = double.Parse(values[0]);
            endHour = double.Parse(values[1]);

            if(startHour < endHour){
              duration = endHour - startHour;
              Console.WriteLine("Duracao da partida: " + duration+" horas");
            }else{
                duration = 24 - startHour + endHour;
                Console.WriteLine("Duracao da partida: " + duration+" horas");
                
            }
            
        }
    }
}