using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic = "not specific to a particular data type"
            //     add <T> to: classes, methods, fields, etc. to make them generic
            //     allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
            //now we can use the same method to display elements of different data types
            //without having to write separate methods for each type.
        }   
        //public static void displayElements(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.Write(item);
        //        Console.WriteLine();
        //  }
        //  }
        //public static void displayElements(double[] array)
        //{
        //  foreach (double item in array)
        //  {
        //      Console.Write(item);
        //      Console.WriteLine();
        //  }
     // }
    //  public static void displayElements(string[] array)
     // {
     //     foreach (string item in array)
      //    {
      //        Console.Write(item + " ");
      //        Console.WriteLine();
      //    }
     // }
     public static void displayElements<T>(T[] array)
     {
             foreach (T item in array)
             {
             Console.Write(item + " ");
             Console.WriteLine();
             }
     }

    }
    
}
