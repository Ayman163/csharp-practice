using System;
using System.Runtime.CompilerServices;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
                ba.AccountName = "Ayman";
                ba.AccountNumber = "IQ-99824";
            try
            {
                Console.Write("Enter amount to Deposit: $");
                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                ba.Deposit(depositAmount);
                Console.WriteLine($"[Success] Deposited: ${depositAmount:F2}");

                Console.Write("Enter amount to Withdraw: $");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                ba.Withdraw(withdrawAmount);
                Console.WriteLine($"[Success] Withdrew: ${withdrawAmount:F2}");

                
            }
            catch (FormatException)
            {
                Console.WriteLine("\n[Error]: Please enter a valid numerical amount!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n[Validation Error]: {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"\n[Transaction Error]: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[Unexpected Error]: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"\n--- Account Status ---");
                Console.WriteLine($"Account Holder : {ba.AccountName}");
                Console.WriteLine($"Account Number : {ba.AccountNumber}");
                Console.WriteLine($"Current Balance: ${ba.Balance:F2}");
            }


        }
    }
     public class BankAccount
    {
        public String AccountName{get; set;}
        public String AccountNumber{get; set;}
        private decimal _Balance;


        public decimal Balance{get{return _Balance;}}


        public decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }

            return _Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }

            return _Balance -= amount;
        }
    }
}
