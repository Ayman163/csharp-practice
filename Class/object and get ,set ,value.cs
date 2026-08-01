using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // use new to creat Object  
        Computer myPc = new Computer();
        myPc.ModelName = "Custom Ryzen Gaming Rig";
        myPc.RamGb = 16;
        myPc.Price = 750.00m;

        // to use object
        myPc.DisplaySpecs();
        }
    }
    public class Computer
{
    // (Private Field)
    private decimal _price;

    // (Encapsulated Property)

    //get mean:Allow everyone to read this variable
    //setmean:Allow everyone to edit/write this variable
    public string ModelName { get; set; }
    public int RamGb { get; set; }

    public decimal Price
    {
        get { return _price; }
        set
        {
            //value mean:The C# language creates a hidden variable called (value) and stores the number you wrote in it.
            if (value <= 0)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
            _price = value;
        }
    }

    //(Method)
    public void DisplaySpecs()
    {
        Console.WriteLine($"Model: {ModelName}, RAM: {RamGb}GB, Price: ${_price:F2}");
    }
}
}
