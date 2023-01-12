using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingSaving
{
    internal class SavingAcct : IMethods
    {
        public string AccountOwner;
        public decimal Balance;
        private double intererst;
        public SavingAcct(string ChkOwnrName, string ChkOenrSurname, double _interest, decimal InitalBalance)
        {
            AccountOwner = ChkOwnrName + " " + ChkOenrSurname;
            Balance = InitalBalance;
            intererst = _interest;
        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }
        private int withdrowCount = 0;
        public void Withdraw(decimal wdamount)
        {
            withdrowCount++;
            if (withdrowCount<=3)
            {
                if ((Balance - wdamount) >= 0)
                {
                    Balance -= wdamount;
                }
                else
                {
                    Console.WriteLine("Balansda kifayet qeder mebleg yoxdur");
                }
            }
            else
            {
                if ((Balance - wdamount) >= 2)  // 2.00m komissiya tutmaga yer saxlayiram :) (eyni zamanda balans menfiye dusmemelidir)
                {
                    Balance -= (wdamount + 2);
                }
                else
                {
                    Console.WriteLine("Balansda kifayet qeder mebleg yoxdur");
                }
            }
        }
        public void ApplyInterest()
        {
            Balance += (Balance * (decimal)intererst);
        }
    }
}
