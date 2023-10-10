//Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.
using System;

namespace Exercice01{
    class Program{
        public static void Main(){
            Informations person1,person2 ;
            
            person1 = new Informations();
            person2 = new Informations();

            Console.Write("Digite o nome da primeira pessoa: ");
            person1.Name = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            person1.Age = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            person2.Name = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            person2.Age = int.Parse(Console.ReadLine());

            if(person1.Age > person2.Age){
                Console.Write(person1.Name +" é mais velho");
            }else if (person1.Age < person2.Age){
                Console.Write(person2.Name +" é mais velho");
            }else{
                Console.Write(person1.Name +" e "+ person2.Name+" , possuem a mesma idade.");
            }
        }
    }
}
