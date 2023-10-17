using System.Globalization;
using System;
namespace StockStore

{
    public class Products
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double ValueTotalInStock(){
            return Price * Quantity;
        }

        public void AddQuantityProducts(int quantityAdd){
            Quantity = Quantity + quantityAdd;
        }

        public void RemoveQuantityProducts(int quantityAdd){
            Quantity = Quantity - quantityAdd;
        }
        public override string ToString()
        {
            return Name 
            + ", $"
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantity
            + " unidades, Total: $"
            + ValueTotalInStock().ToString("F2", CultureInfo.InvariantCulture);

        }




    }
}