//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
using System;

namespace ExercicesWhileStructures{
    class Program{
        static void Main(string[] args){
            int password;
            Console.Write("Digite sua senha: ");
            password = int.Parse(Console.ReadLine());
            while(password != 2000){
                Console.WriteLine("Senha incorreta.");
                Console.Write("Digite sua senha novamente: ");
                password = int.Parse(Console.ReadLine());
            }
            Console.Write("Acesso permitido.");
            
        }
    }
}