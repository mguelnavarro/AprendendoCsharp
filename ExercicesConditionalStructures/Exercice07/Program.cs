using System;
using System.Globalization;

namespace ExercicesCondionalStructures{
    class Program{
        static void Main(string[] args){
            double salary, tax;
            Console.Write("Digite seu sálario: ");
            salary = double.Parse(Console.ReadLine());
            if(salary >=0 && salary <= 2000){
                Console.Write("Isento de imposto");
            }else if(salary >= 2000.01 && salary <= 3000  ){
                tax = salary * 0.08;
                Console.Write($"Valor do imposto a ser pago: {tax} reais.");
            }else if(salary >= 3000.01 && salary <= 4500){
                tax = salary * 0.18;
                Console.Write($"Valor do imposto a ser pago: {tax} reais.");
            }else if(salary >= 4500.01){
                tax = salary * 0.28;
                Console.Write($"Valor do imposto a ser pago: {tax.ToString("F2", CultureInfo.InvariantCulture)} reais.");

            }

            
        }
    }
}