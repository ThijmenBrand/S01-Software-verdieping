using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pinService
{
    internal class pinAutomaat
    {
        protected bool pin(long bankAccountId, long bankAccountName, bankAccount account, double amount)
        {
            if(checkPin()) {

            }
        }

        private bool checkPin(string inputPin, string pin)
        {
            int intInput;
            int intPin;
            if(int.TryParse(inputPin, out intInput) && int.TryParse(pin, out intPin) && intInput == intPin)
            {
                return true;
            }
            return false;
        }
    }
}
