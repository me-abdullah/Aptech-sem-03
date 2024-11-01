using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BankAccount
    {
        private decimal balance; // Private field

        // Public property to get the balance
        public decimal Balance
        {
            get { return balance; }
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount; // Only allow positive amounts
                Console.WriteLine($"Deposited: {amount:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount; // Only allow withdrawals if sufficient balance
                Console.WriteLine($"Withdrawn: {amount:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            // Deposit money
            account.Deposit(100);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            // Withdraw money
            account.Withdraw(50);
            Console.WriteLine($"Current Balance: {account.Balance:C}");

            // Attempt to withdraw more than the balance
            account.Withdraw(60);

            // Final balance
            Console.WriteLine($"Final Balance: {account.Balance:C}");
            Console.ReadKey();
        }
    }
}
