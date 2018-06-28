using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Bank
    {
        public int BankAccount { get; set; }
        public Bank()
        {
            BankAccount = BankAccount;
        }
        public void DepositMoney(int deposit)
        {
            BankAccount += deposit;
        }
    }
}
