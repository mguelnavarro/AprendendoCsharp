//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora
//calcular o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais
using System;
using System.Globalization;

namespace Exercice04{
    class Program{
        public static void Main(){
        
        double numberEmployee, hoursWorked, valueReceives, calculeSalary;
        
        Console.WriteLine("----Sistema de Salário----");
        Console.Write("Digite o número do funcionário: ");
        numberEmployee = double.Parse(Console.ReadLine());
        Console.Write("Digite o número de horas trabalhadas: ");
        hoursWorked = double.Parse(Console.ReadLine());
        Console.Write("Digite o valor que o funcionário ganha por hora trabalhada: ");
        valueReceives = double.Parse(Console.ReadLine());
        
        calculeSalary = hoursWorked * valueReceives;

        Console.WriteLine("Número do funcionário: "+numberEmployee);
        Console.WriteLine("Salário do funcionário: "+valueReceives.ToString("F2", CultureInfo.InvariantCulture));
        }



        
    }
}