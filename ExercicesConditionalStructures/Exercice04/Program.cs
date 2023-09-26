//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
//seguir, calcule e mostre o valor da conta a pagar
// Cachorro quente - Codigo: 1 - Valor: 4 R$
// X-salada - Código : 2 - Valor: 4,50 R$
// X-bacon - Código : 3 - Valor: 5 R$
// Torrada simples - Código: 4 - Valor : 2 R$
// Refrigerante - Código: 5 - Valor: 1,50 R$
using System;

namespace ExercicesCondionalStructures{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Digite o código do produto e a quantidade, na mesma linha(Exemplo: 1 3)");
            string[] values = Console.ReadLine().Split(" ");
            int code = int.Parse(values[0]);
            int quantity = int.Parse(values[1]);
            
            switch(code){
                case 1:
                Console.Write($"Total a ser pago: {quantity * 4.0} reais");
                break;
                case 2:
                Console.Write($"Total a ser pago: {quantity * 4.5} reais");
                break;
                case 3:
                Console.Write($"Total a ser pago: {quantity * 5} reais");
                break;
                case 4:
                Console.Write($"Total a ser pago: {quantity * 2} reais");
                break;
                case 5:
                Console.Write($"Total a ser pago: {quantity * 1.5} reais");
                break;

                

            }

        }
    }
}