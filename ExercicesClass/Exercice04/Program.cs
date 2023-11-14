
//Fazer um programa para ler os dados de um funcionário (nome,
//salário bruto e imposto). Em seguida, mostrar os dados do
//funcionário (nome e salário líquido). Em seguida, aumentar o salário
//do funcionário com base em uma porcentagem dada (somente o
//salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.

namespace Exercice04{
    class Program{
        public static void Main(){
            Employees employee = new Employees();

            Console.Write("Digite o nome do funcionário: ");
            employee.Name = Console.ReadLine();
            Console.Write("Digite o salário bruto do funcionário: ");
            employee.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Digite o imposto do salário: ");
            employee.Impost = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Dados do funcionário: "+employee);
            Console.WriteLine();
            
            Console.Write("Digite o percentual para ser adicionado, ao salário do funcionário: ");
            double quantityAdd = double.Parse(Console.ReadLine());
            
            employee.AddPercentualSalary(quantityAdd);

            Console.Write("Dados do funcionário atualizados: "+employee);
        }
    }
}