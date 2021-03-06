using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class SavingAccount : Account
    {
        public SavingAccount(int accountNumber,string accountName, string dateOfBirth, double balance, Address address) 
        {
            base.accountName = accountName;
            base.accountNumber = accountNumber;
            base.dateOfBirth = dateOfBirth;
            base.balance = balance;
            base.address = address;
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount < base.balance)
            {
                Console.WriteLine("Previous Balance : {0}\ntWithdraw Amount: {1}", base.balance, amount);
                base.balance = base.balance-amount;
                Console.WriteLine("Current Balance: " + base.balance);
                base.transactions++;
            }
            else Console.WriteLine("Withdraw unsucessful.....");
        }
        public override void Transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount < base.balance)
            {
                Console.WriteLine("Previous Balance : {0}\nTransfer Amount: {1}", base.balance, amount);
                base.balance = base.balance-amount;
                receiver.Balance = receiver.Balance + amount;
                Console.WriteLine("Current Balance: " + base.balance);
                base.transactions++;
            }
            else Console.WriteLine("Transfer Unsucessful.....");
        }
    }
}
