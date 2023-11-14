namespace Exercice03
{
    public class Rectangle
    {
        public double Breadth;
        public double Height;

        public double Area(){
            return Breadth * Height;
        }

        public double Perimeter(){
            return (Breadth * 2) + (Height * 2);
        }

        public double Diagonal(){
            return Math.Sqrt((Breadth * Breadth) + (Height * Height));
        }
    }
}