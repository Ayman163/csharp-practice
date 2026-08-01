using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor mon = new Monitor();
            
            Console.Write("Enter the name of screen Brand:");
            mon.Brand = Console.ReadLine();

            Console.Write("Enter the RefreshRate of screen:");
            mon.RefreshRateHz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of screen:");
            mon.ScreenSizeInches = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the price of screen:");
            mon.price = Convert.ToDecimal(Console.ReadLine());

            mon.DisplayMonitorInfo();

        }
    }
    public class Monitor
    {
        private int RefreshRateHz1;
        private double ScreenSizeInches1;

        private decimal _price;
        public String Brand {get; set;}
        public int RefreshRateHz {get {return RefreshRateHz1;}
        set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("RefreshRateHz must be greater than zero.");
                }RefreshRateHz1 = value;
            }
            
        }

        public double ScreenSizeInches {get{return ScreenSizeInches1;} set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("ScreenSizeInches must be greater then zrto.");
                }ScreenSizeInches1 = value;
            }
        }
        public decimal price{get {return _price;}
        set
            {
                if (value <= 50)
                {
                    throw new ArgumentException("price must be greater than 50.");
                }_price = value;
            }
            
        }
        public void DisplayMonitorInfo()
        {
            Console.WriteLine("\n--- Monitor Specifications ---");
            Console.WriteLine($"Brand        : {Brand}");
            Console.WriteLine($"Refresh Rate : {RefreshRateHz} Hz");
            Console.WriteLine($"Screen Size  : {ScreenSizeInches} inches");
            Console.WriteLine($"Price        : ${price:F2}");
        }
        }

    
}
