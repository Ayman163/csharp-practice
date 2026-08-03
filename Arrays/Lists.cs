using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //array we can't change the size of it
            //String[] food = new string[3];
            //food[0] = "pizza";
            //food[1] = "hamburger";
            //food[2] = "hotdog";
            //foreach (String item in food)
            //{Console.WriteLine(item);}

            //list we can change the size of it 
            //and to use the list we need to add using System.Collections.Generic;
            List<string> food = new List<string>();
            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("taco");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            food.Remove("taco");
            Console.WriteLine("After removing taco");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            food.Insert(0, "ice cream");
            Console.WriteLine("After inserting ice cream");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The food list has " + food.Count + " items in it");
            Console.WriteLine("The index of 'pizza' is: " + food.IndexOf("pizza"));
            food.Add("pizza");
            Console.WriteLine("The last index of 'pizza' is: " + food.LastIndexOf("pizza"));
            Console.WriteLine("The food list contains 'hotdog': " + food.Contains("hotdog"));
            food.Sort();
            Console.WriteLine("After sorting the food list");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            food.Reverse();
            Console.WriteLine("After reversing the food list");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            food.Clear();
            Console.WriteLine("After clearing the food list");
            foreach (String item in food)
            {
                Console.WriteLine(item);
            }
            food.Add("pizza");
            food.Add("hamburger");
            String[] foodArray = food.ToArray();
            Console.WriteLine("After converting the food list to an array");
            foreach (String item in foodArray)
            {
                Console.WriteLine(item);
            }

        }   
    }
    
}
