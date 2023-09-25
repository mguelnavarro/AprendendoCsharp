//Diferença do produto de A e B pelo produto de C e D 
using System;

namespace Exercice03{
    class Program{
        public static void Main(){
            double number1,number2,number3,number4;
            double product1,product2, resultProducts;
            
            Console.WriteLine("Diferença do produto de A e B");
            Console.Write("Digite o primeiro número: ");
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            number2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            number3 = double.Parse(Console.ReadLine());            
            Console.Write("Digite o quarto número: ");
            number4 = double.Parse(Console.ReadLine());

            product1 = number1 * number2;
            product2 = number3 * number4;
            Console.WriteLine($"Produto dos dois primeiros números: {product1} ");
            Console.WriteLine($"Produto dos dois ultimos números: {product2}");

            resultProducts = product1 - product2;

            Console.Write($"Resultado da diferença dos produtos: {resultProducts} ");

            
        }
    }
}