using System;

namespace Exercice05{
    class Program{
        public static void Main(){
            Student studentSchool = new Student();

            Console.Write("Digite o nome do aluno: ");
            studentSchool.Name = Console.ReadLine();
            
            Console.WriteLine("Digite a nota do primeiro trimestre: (Peso: 30)");
            studentSchool.FirstNote = double.Parse(Console.ReadLine()); 
             while(studentSchool.FirstNote > 30){
                Console.WriteLine("Erro, a possível nota máxima, é 30\nDigite do primeiro trimestre: (Peso: 30)");
                studentSchool.FirstNote = double.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Digite a nota do segundo trimestre: (Peso: 35)");
            studentSchool.SecondNote = double.Parse(Console.ReadLine());
            while(studentSchool.SecondNote > 35){
                Console.WriteLine("Erro, a possível nota máxima, é 35\nDigite do segundo trimestre: (Peso: 35)");
                studentSchool.FirstNote = double.Parse(Console.ReadLine()); 
            }
            
            Console.WriteLine("Digite a nota do terceiro trimestre: (Peso: 35)");
            studentSchool.ThirdNote = double.Parse(Console.ReadLine());
            while(studentSchool.ThirdNote > 35){
                Console.WriteLine("Erro, a possível nota máxima, é 35\nDigite do terceiro trimestre: (Peso: 35)");
                studentSchool.FirstNote = double.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Nota final =  "+ studentSchool.FinalNote());
            if(studentSchool.FinalNote() < 60){
             Console.WriteLine($"REPROVADO\nRESTAM {60 - studentSchool.FinalNote()} pontos");
            }else{
                Console.Write("APROVADO");
            }
        }
    }
}