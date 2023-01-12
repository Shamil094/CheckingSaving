using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingSaving
{
    internal class CheckingAcct:IMethods
    {
        public string AccountOwner;
        public decimal Balance;

        public CheckingAcct(string ChkOwnrName,string ChkOenrSurname,decimal InitalBalance )
        {
            AccountOwner = ChkOwnrName + " " + ChkOenrSurname;
            Balance = InitalBalance;
        }

        public void Deposit(decimal deposit)
        {
            Balance += deposit;
        }

        public void Withdraw(decimal wdamount)
        {
            if ((Balance - wdamount) >= 0)
            {
                Balance -= wdamount;
            }
            else
            {
                Balance -= (wdamount + 35);
            }
        }
    }
}
