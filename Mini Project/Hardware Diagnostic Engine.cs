using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            HardwareComponent[] components = new HardwareComponent[2];
            components[0] = new CPU { ComponentName = "Intel Core i9", TemperatureC = 65, ClockSpeedGhz = 3.6 };
            components[1] = new GPU { ComponentName = "NVIDIA RTX 3080", TemperatureC = 85, VramUsageGb = 10 };
            foreach (var component in components)
            {
                component.Diagnose();
                Console.WriteLine();
            }
        }   
    }
    class HardwareComponent
    {
        public String ComponentName;
        public double TemperatureC;
        public  virtual void Diagnose()
        {
            Console.WriteLine("Diagnosing hardware component: " + ComponentName);
            Console.WriteLine("Temperature: " + TemperatureC + "°C");
        }
    }
    class CPU : HardwareComponent
    {
        public double ClockSpeedGhz;
        public override void Diagnose()
        {
            base.Diagnose();
            Console.WriteLine("Clock Speed: " + ClockSpeedGhz + " GHz is optimal.");
        }
    }
    class GPU : HardwareComponent
    {
        public double VramUsageGb;
        public override void Diagnose()
        {
            base.Diagnose();
            Console.WriteLine("VRAM Usage: " + VramUsageGb + " GB");
            if (TemperatureC > 80)
            {
                Console.WriteLine("Warning: GPU temperature is high! Consider improving cooling.");
            }
            else
            {
                Console.WriteLine("GPU temperature is within safe limits.");
            }
        }
    }
}
