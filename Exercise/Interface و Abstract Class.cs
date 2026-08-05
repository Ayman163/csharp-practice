using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GamingMouse mouse = new GamingMouse
            {
                DeviceName = "Logitech G Pro X"
            };

            //use  the mouse object to call the methods 
            mouse.TurnOn();
            mouse.Connect();
            mouse.TurnOff();
        }  
        
    }
    public interface IPowerController
    {
        void TurnOn();
        void TurnOff();
    }
    public abstract class PeripheralDevice
    {
        public String DeviceName{get; set;}
        public abstract void Connect();
    }
    
    public class GamingMouse : PeripheralDevice, IPowerController
    {
        public override void Connect()
        {
            Console.WriteLine($"[Connection]: {DeviceName} has been connected via USB.");
        }

        public void TurnOn()
        {
            Console.WriteLine($"[Power]: {DeviceName} RGB lighting is ON.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"[Power]: {DeviceName} is entering sleep mode.");
        }
    }
}
