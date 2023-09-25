//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre
//a) a área do triângulo retângulo que tem A por base e C por altura.
//b) a área do círculo de raio C. (pi = 3.14159)
//c) a área do trapézio que tem A e B por bases e C por altura.
//d) a área do quadrado que tem lado B.
//e) a área do retângulo que tem lados A e B.
using System;
using System.Globalization;

namespace Exercice06{
    class Program{
        public static void Main(){
         double A,B,C,triangleRectangle,square,circle,trapeze,rectangle,pi;
         
         pi = 3.14159;

         string[] vet = Console.ReadLine().Split(" ");
         A = double.Parse(vet[0]);
         B = double.Parse(vet[1]);
         C = double.Parse(vet[2]);

         triangleRectangle =  (A * C) / 2;
         circle = pi * (Math.Pow(C, 2.0));
         trapeze = ((A + B) * C)/2;
         square = B * B;
         rectangle = A * B;

         Console.WriteLine("Área do triangulo retangulo: "+triangleRectangle);
         Console.WriteLine("Área do círculo: "+circle.ToString("F2",CultureInfo.InvariantCulture));
         Console.WriteLine("Área do trapézio: "+trapeze);
         Console.WriteLine("Área do quadrado: "+square);
         Console.WriteLine("Área do retangulo: "+rectangle);
        }
    }
}