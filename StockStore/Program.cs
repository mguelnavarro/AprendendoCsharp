using System;
using System.Reflection.Metadata;

namespace StockStore{
    class Program{
        public static void Main(string[] args){
            Products product = new Products();
            
            bool select = true;
            while(select == true){
            Console.Write("Selecione o numero da açao no estoque:\n1 - Iniciar \n2- Sair\n ");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1 ){
            Console.WriteLine("Insira os dados do produto");
            Console.Write("Digite o nome do produto: ");
            product.Name = Console.ReadLine();
            if(product.Name.GetType() == typeof(string)){
                Console.Write("Nome inválido.");
                break;
            }
            Console.Write("Digite o preço do produto: ");
            product.Price = double.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade: ");
            product.Quantity = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            
            Console.WriteLine($"Dados do produto: {product} ");
           
            Console.Write("Selecione o numero da açao no estoque: \n1 - Adicionar quantidade do produto ao estoque \n2- Remover quantidade do produto ao estoque \n3 - Encerrar\n");
            int choiceAddOrRemove = int.Parse(Console.ReadLine());
            
            if(choiceAddOrRemove == 1){
            Console.Write("Digite a quantidade de produtos á serem adicionados do estoque: ");
            int addProducts = int.Parse(Console.ReadLine());
            product.AddQuantityProducts(addProducts);

            System.Console.WriteLine();

            Console.WriteLine("Dados atualizados: "+ product);
            
            }else if(choiceAddOrRemove == 2){
             Console.Write("Digite a quantidade de produtos á serem removidos do estoque: ");
             int removeProducts = int.Parse(Console.ReadLine());
             product.RemoveQuantityProducts(removeProducts);

             System.Console.WriteLine();

             Console.WriteLine("Dados atualizados: "+ product);
            }else if(choiceAddOrRemove == 3){
                Console.Write("Fim.");
                select = false;
            }


            }else if(choice == 2){
             Console.WriteLine("Fim");
             select = false;
            }
            
            }
            
        }
    }
}