using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myLaptop = new Laptop { Brand = "Dell", Price = 1200m, BatteryLifeHours = 8 };
            Computer myDesktop = new Desktop { Brand = "Custom PC", Price = 2000m, PowerSupplyWattage = 750 };

            myLaptop.DisplayInfo();
            myDesktop.DisplayInfo();
        }   
    }
        //(Base Class)
    public class Computer
    {
        public string Brand { get; set; }
        public decimal Price { get; set; }

        //virtual mean we can edit it
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Price: ${Price:F2}");
        }
    }

    public class Laptop : Computer
    {
        public int BatteryLifeHours { get; set; }

        // override mean to edit it
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Life: {BatteryLifeHours} hours");
        }
        
        
    }
     public class Desktop : Computer
    {
        public int PowerSupplyWattage { get; set; }

        // override mean to edit it
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"PowerSupply: {PowerSupplyWattage} Wattage");
        }
        
        
    }
}
