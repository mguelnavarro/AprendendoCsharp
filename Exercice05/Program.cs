//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1
//o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
using System;

namespace Exercice05{
    class Program{
        public static void Main(){
            double codePiece1,quantityPieces1,valuePiece1,codePiece2,quantityPieces2,valuePiece2;
            
            Console.WriteLine("Caixa da Loja");
            Console.Write("Digite o código da primeira peça: ");
            codePiece1 = double.Parse(Console.ReadLine());
           
            Console.Write("Digite o número de peças: ");
            quantityPieces1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor da peça: ");
            valuePiece1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o código da segunda peça: ");
            codePiece2 = double.Parse(Console.ReadLine());
           
            Console.Write("Digite o número de peças: ");
            quantityPieces2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor da peça: ");
            valuePiece2 = double.Parse(Console.ReadLine());

            Console.Write("Valor total a ser pago: "+ ((quantityPieces1 * valuePiece1) + (quantityPieces2 * valuePiece2))+" reais");


            
        }
    }
}