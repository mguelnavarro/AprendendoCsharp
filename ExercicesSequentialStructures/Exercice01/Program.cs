//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos
using System;

namespace Exercice01{
  class Program{
    public static void Main(){
      Console.WriteLine("Soma de números inteiros");
      Console.Write("Digite o primeiro número inteiro: ");
      int number1 = int.Parse(Console.ReadLine());
      Console.Write("Digite o segundo número inteiro: ");
      int number2 = int.Parse(Console.ReadLine());    

      Console.WriteLine($"Números inseridos,{number1} e {number2}");
      Console.WriteLine("Resultado da soma dos números inteiros: "+ (number1 + number2));

    }
  }
}