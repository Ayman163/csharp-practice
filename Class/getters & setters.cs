using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 50000000; // setter will set the value of the private field speed to 500
            Console.WriteLine(car.Speed); // getter will return the value of the private field speed which is 500
        }   
    }
    class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; } // getter well returns the value of the private field speed
            set { 
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
                 } // setter well sets the value of the private field speed
        }
    }
}
