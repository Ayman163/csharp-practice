using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                Char o = ' ';
                a = "";
                Console.WriteLine("------------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an opition of :");
                Console.WriteLine("+ :Add");
                Console.WriteLine("- :Subtract");
                Console.WriteLine("* :Multiply");
                Console.WriteLine("/ :Divide");
                Console.WriteLine("Enter an opition:");

                o = Convert.ToChar(Console.Read());

                switch(o)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case '/':
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y/N): ");
                a = Console.ReadLine().ToUpper();
            } while (Console.ReadLine().ToUpper() == "Y");
            

                

            
        }
    }
}
