using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota");
            Console.WriteLine("Car model is: " + car.Model);
        }   
    }
    class Car
    {
        //Backing field = A private variable that stores the value of a property.
        // It is used to encapsulate the data and provide controlled access to it through the property.
        //String model;
        //public String Model
        //
        //  get { return model; }
        //  set { model = value; }
        //

        //Auto-implemented property = Simpler way to create a property without explicitly defining a backing field 
        //you can use auto-implemented properties when no additional logic is required in the property accessors.
        //You only have to write get; and set; without any additional code.
        public String Model { get; set; }
        public Car(String model)
        {
            this.Model = model;
        }
    }
    
}
