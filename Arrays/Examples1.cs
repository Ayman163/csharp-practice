using System;
using System.Collections.Generic;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> components = new List<string>();
            components.Add("RTX 4090");
            components.Add("Ryzen 7 7800X3D");
            Console.WriteLine($"Total components: {components.Count}");
            components.Remove("RTX 4090");
        }
    }
}
