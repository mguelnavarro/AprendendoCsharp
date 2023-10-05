//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
//exemplo.

using System;

namespace ExercicesWhileStructures{
    class Program{
        public static void Main(){
            double alcohol = 0;
            double gasoline = 0;
            double diesel = 0;
            double type;
            Console.Write("Digite o tipo de combustível abastecidon\n1(Alcool)\n2(Gasolina)\n3(Diesel)\n4(Sair)):\n");
            type = double.Parse(Console.ReadLine());

            while(type != 4){
                if(type == 1){
                    alcohol = alcohol + 1;
                }else if(type == 2){
                    gasoline = gasoline + 1;
                }else if(type == 3){
                    diesel = diesel + 1;
                }
                Console.Write("Digite o tipo de combustível abastecido \n1(Alcool)\n2(Gasolina)\n3(Diesel)\n4(Sair)):\n");
                 type = double.Parse(Console.ReadLine());


            }
            Console.WriteLine("Obrigado!");
            Console.WriteLine($"Alcool: {alcohol}");
            Console.WriteLine($"Gasolina: {gasoline}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}