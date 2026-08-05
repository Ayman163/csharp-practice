using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            GpuDriver gpu = new GpuDriver { DeviceName = "NVIDIA RTX 4080", DriverVersion = "551.23" };
            AudioDriver audio = new AudioDriver { DeviceName = "Realtek High Definition Audio", DriverVersion = "6.0.9" };

            IDriverUpdatable[] drivers = new IDriverUpdatable[2];
            drivers[0] = gpu;
            drivers[1] = audio;

            Console.WriteLine("=== Starting System Driver Update Framework ===\n");

            gpu.LogInstallation();
            gpu.VerifyHardware();

            Console.WriteLine();

            audio.LogInstallation();
            audio.VerifyHardware();

            Console.WriteLine("\n=== Updating Drivers via Interface Contract ===");

            foreach (var driver in drivers)
            {
                driver.UpdateDriver();
            }
        }
    }

    public interface IDriverUpdatable
    {
        void UpdateDriver();
    }

    public abstract class HardwareDriver
    {
        public string DriverVersion { get; set; }
        public string DeviceName { get; set; }

        public void LogInstallation()
        {
            Console.WriteLine($"Log: Installing driver for {DeviceName} version {DriverVersion}...");
        }

        public abstract bool VerifyHardware();
    }

    public class GpuDriver : HardwareDriver, IDriverUpdatable
    {
        public override bool VerifyHardware()
        {
            Console.WriteLine("GPU hardware verification passed.");
            return true;
        }

        public void UpdateDriver()
        {
            Console.WriteLine("Downloading latest NVIDIA/AMD display driver...");
        }
    }

    public class AudioDriver : HardwareDriver, IDriverUpdatable
    {
        public override bool VerifyHardware()
        {
            Console.WriteLine("Soundcard hardware verification passed.");
            return true;
        }

        public void UpdateDriver()
        {
            Console.WriteLine("Updating Realtek HD Audio codecs...");
        }
    }
}
