using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Inventory = {"  RTX 4090 ", " rx 7900 xt ", "Intel i9 ", "  ryzen 7 5700x", "RTX 3060 "};
            string textSearch;
            int x = 1;
            
            Console.WriteLine("--- Current Inventory ---");

            for (int i = 0;i <  Inventory.Length;i++)
            {
                Inventory[i] = PrintCleanInventory(Inventory[i]);
                Console.WriteLine($"{x++}. {Inventory[i]}");
            }
            Console.Write("Enter search term: ");
            textSearch = Console.ReadLine();

                Console.WriteLine(SearchProduct(Inventory,textSearch));
            
            
        }
            public static String PrintCleanInventory(string nameOfproduct)
        {
            
                string nameOfProduct1 = nameOfproduct.Trim().ToUpper();
         return nameOfProduct1;       
        }
            public static String SearchProduct (string[] Inventory, string textSearch)
            {
                bool hasProduct = false;
                string a ="";

                string textSearch1 = textSearch.Trim().ToUpper();
                for (int i = 0;i <  Inventory.Length;i++){
                if (hasProduct = Inventory[i].Contains(textSearch1))
            {
                a = $"Result: Found -> {textSearch1}";
                break;
            }
                else
            {
               a = "No product matched your search." ;
            }
                }

                return a;
            }
      
    }
}
