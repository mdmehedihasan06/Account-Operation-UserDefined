using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationApp
{
    class Account
    {
        public string accountNo;
        public string name;
        public double balance;

        public string Deposit(double amount)
        {
            balance += amount;
            return "Deposited";
        }

        public string Withdraw(double amount)
        {
            balance -= amount;
            return "Withdrawn";
        }
    }
}
