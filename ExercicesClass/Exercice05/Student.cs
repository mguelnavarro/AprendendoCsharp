namespace Exercice05
{
    public class Student
    {
        public string Name;
        public double FirstNote;
        public double SecondNote;
        public double ThirdNote;

        public double FinalNote(){
         return FirstNote + SecondNote + ThirdNote;
        }


    }
}