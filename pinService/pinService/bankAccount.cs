using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinService
{
    internal class bankAccount
    {
        private string bankAccountName;
        private long bankAccountID;
        private long nextFreeAccountId = 456903834909306;
        private double saldo;

        public bankAccount(string bankAccountName, int saldo)
        {
            this.bankAccountName = bankAccountName;
            this.saldo = saldo;
            bankAccountID = nextFreeAccountId;
            nextFreeAccountId++;
        }

        public bool reduceSaldo(double amount)
        {
            if(amount < saldo && amount > 0)
            {
                saldo -= amount;
                return true;
            }
            return false;
        }

        public bool addSaldo(double amount)
        {
            if(amount > 0)
            {
                saldo += amount;
                return true;
            }
            return false;
        }
    }
}
