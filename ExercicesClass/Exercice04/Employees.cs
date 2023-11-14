using System.Globalization;
namespace Exercice04
{
    public class Employees
    {
        public string Name;
        public double GrossSalary;
        public double Impost;




        public override string ToString()
        {
            return Name 
            + ", $"
            + (GrossSalary - Impost).ToString("F2", CultureInfo.InvariantCulture);

        }
         public void AddPercentualSalary(double quantityAdd){
            GrossSalary = GrossSalary + (GrossSalary * quantityAdd / 100.0);
        }

    }
}