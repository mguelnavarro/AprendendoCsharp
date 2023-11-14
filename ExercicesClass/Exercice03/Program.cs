//Fazer um programa para ler os valores da largura e altura de um retângulo. Em
//seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
using System;

namespace Exercice03{
    class Program{
        public static void Main(){
            Rectangle rectangle = new Rectangle();

            Console.Write("Digite a largura do retangulo: ");
            rectangle.Breadth = double.Parse(Console.ReadLine());
            
            Console.Write("Digite a altura do retangulo: ");
            rectangle.Height = double.Parse(Console.ReadLine());

            double area = rectangle.Area();
            double perimeter = rectangle.Perimeter();
            double diagonal = rectangle.Diagonal();

            Console.WriteLine("Área do retangulo: "+ area);
            Console.WriteLine("Perímetro do retangulo: "+ perimeter);
            Console.WriteLine("Diagonal do retangulo: "+ diagonal);
        }
    }
}