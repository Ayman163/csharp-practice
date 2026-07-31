using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int userAge = Convert.ToInt32(Console.ReadLine());

                if (userAge < 0 || userAge > 120)
                {
                    throw new ArgumentOutOfRangeException(nameof(userAge), "Age must be between 0 and 120.");
                }

                Console.WriteLine($"Your age ({userAge}) has been accepted successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number, not text!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Validation Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Age verification process completed.");
            }
        }
    }
}
