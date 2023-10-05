//Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
//de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
//conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
//peso 5.
using System;

namespace ExercicesForStructures{
    class Program{
        public static void Main(){
            Console.Write("Digite o número boletins a serem realizados: ");
            int numberOfBulletins = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfBulletins; i++){
                double note1,note2,note3,mean;
                Console.Write("Digite a nota do primeiro teste: ");
                note1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a nota do segundo teste: ");
                note2 = double.Parse(Console.ReadLine());                
                Console.Write("Digite a nota do terceiro teste: ");
                note3 = double.Parse(Console.ReadLine());

                mean = (note1 * 2 + note2 * 3 + note3 * 5) / 10;
                Console.WriteLine($"Media final : {mean}");
            }
        }
    }
}