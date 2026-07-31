using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal exchangeRate = 1500;
                
                Console.Write("Enter the amount in USD ($): ");
                decimal usdAmount = Convert.ToDecimal(Console.ReadLine());

                decimal iqdAmount = ConvertToIqd(usdAmount, exchangeRate);

                Console.WriteLine($"\n--- Conversion Result ---");
                Console.WriteLine($"Amount: ${usdAmount:F2} USD = {iqdAmount:N0} IQD");
              }
            catch (FormatException)
            {
                Console.WriteLine("\n[Error]: Please enter a valid number, text is not allowed!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\n[Validation Error]: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Unexpected Error]: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nThank you for using Safe Currency Converter.");
            }
            
        }
        public static decimal ConvertToIqd(decimal usdAmount, decimal exchangeRate)
        {
             if (usdAmount <= 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(usdAmount), "USD amount must be greater than zero.");
            }

            if (exchangeRate <= 0m)
            {
                throw new ArgumentOutOfRangeException(nameof(exchangeRate), "Exchange rate must be greater than zero.");
            }

            return usdAmount * exchangeRate;
        }
    }
}
