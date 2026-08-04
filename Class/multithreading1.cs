using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           //Thread = an execution path of a program
           //     we can use multiple threads to perform different tasks at the same time
           //     we can use threads to perform tasks in the background while the main thread is running
           //     we can use threads to perform tasks in parallel to improve performance
           //     we can use threads to perform tasks in the background while the main thread is running
           //     we need to write using "System.Threading"; to use threads

           Thread mainThread = Thread.CurrentThread;
           Console.WriteLine($"Main thread: {mainThread.Name}");
           mainThread.Name = "Main Thread";
           Console.WriteLine($"Main thread: {mainThread.Name}");

          //CountDown();
          //CountUp();

          // Create two threads to run the CountDown and CountUp methods 
          // and start them to run in the same time as the main thread
          Thread thread1 = new Thread(CountDown);
          Thread thread2 = new Thread(CountUp);
          thread1.Start();
          thread2.Start();

           Console.WriteLine("Main thread: " + mainThread.Name + " is exiting");

        }
        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds remaining");
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine("Timer #1: Time's up!");
        }
        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds elapsed");
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.WriteLine("Timer #2: Time's up!");
        }
    }
}
