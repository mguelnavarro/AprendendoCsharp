//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos
using System;

namespace Exercice02{
    class Program{
        public static void Main(){
        double circleRadius,pi,area;
        pi = 3.14159;
        
        Console.WriteLine("Calculadora da área de um círculo");
        Console.Write("Digite o valor do raio do círculo: ");
        circleRadius = double.Parse(Console.ReadLine());
        
        area = pi * Math.Pow(circleRadius, 2.0);

        Console.Write("A área do círculo é: "+area);
        }
    }
}