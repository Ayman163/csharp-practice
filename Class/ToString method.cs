using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Camry", 2020, "Red");

            Console.WriteLine(car);
        }   
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;
        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Year: {year}, Color: {color}";
        }
    }
    
}
