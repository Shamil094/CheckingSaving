using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingSaving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);
            SavingAcct saving = new SavingAcct("Jane", "Doe", 0.025, 1000.0m);

            Console.WriteLine($"Checking balance is {checking.Balance:C3}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

            checking.Deposit(200.0m);
            saving.Deposit(150.0m);
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

            checking.Withdraw(50m);
            saving.Withdraw(125m);
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Saving balance is {saving.Balance:C2}");

            saving.ApplyInterest();
            Console.WriteLine($"Saving balace is {saving.Balance:C2}");

            saving.Withdraw(10);
            saving.Withdraw(20);
            saving.Withdraw(30);
            Console.WriteLine($"Saving balance is {saving.Balance:C2}");

            saving.Withdraw(2000m);
            Console.WriteLine($"Saving balance is {saving.Balance:C2}");

            checking.Withdraw(3000);
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");




            Console.Read();
        }
    }
}
