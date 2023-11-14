using System;

namespace ExercicesTest{
    class Program{
        public static void Main(){
            Triangle x, y;
            
            x = new Triangle();
            y = new Triangle();

            Console.Write("Digite as medidas do primeiro triangulo: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine()); 
            x.C = double.Parse(Console.ReadLine()); 

            double areaTriangle1 = x.Area();
            
            Console.Write("Digite as medidas do segundo triangulo: ");
            y.A = double.Parse(Console.ReadLine()); 
            y.B = double.Parse(Console.ReadLine()); 
            y.C = double.Parse(Console.ReadLine());  
            
            double areaTriangle2 = y.Area();

            if(areaTriangle1 > areaTriangle2){
                Console.Write("A área do primeiro triangulo é maior.");
            }else if(areaTriangle1 < areaTriangle2){
                Console.Write("A área do segundo triangulo é maior.");
            }else{
                Console.Write("A área dos triangulos sao iguais.");
            }
        }
    }
}