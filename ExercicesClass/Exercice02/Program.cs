//Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
//médio dos funcionários.
using System;

namespace Exercice02{
    class Program{
        public static void Main(string[] args){
            Employees employee1 = new Employees();
            Employees employee2 = new Employees();
            
            Console.Write("Digite o nome do primeiro funcionário: ");
            employee1.Name = Console.ReadLine();
            Console.Write("Digite o salário do primeiro funcionário: ");
            employee1.Salary = double.Parse(Console.ReadLine());           
            
            Console.Write("Digite o nome do segundo funcionário: ");
            employee2.Name = Console.ReadLine();
            Console.Write("Digite o salário do segundo funcionário: ");
            employee2.Salary = double.Parse(Console.ReadLine());  

            Console.WriteLine($"Nome do primeiro funcionário: {employee1.Name} ");            
            Console.WriteLine($"Salário do primeiro funcionário: {employee1.Salary} ");

            Console.WriteLine($"Nome do segundo funcionário: {employee2.Name} ");            
            Console.WriteLine($"Salário do segundo funcionário: {employee2.Salary} ");    

            Console.Write($"Diferenca dos salários: {(employee1.Salary + employee2.Salary) / 2}");                    
            
            
        }
    }
}

