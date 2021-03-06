using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Account
    {
        private int accountNumber;
        private string accountName;
        protected double balance;
        private string dateOfBirth;
        private Address address;
        protected int transactions;


        public Account(int accountNumber,string accountName, string dateOfBirth, double balance, Address address)
        {
            this.accountName = accountName;
            this.accountNumber = accountNumber;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
     
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public int Transactions
        {
            set { this.transactions = value; }
            get { return this.transactions; }
        }
        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public abstract void Withdraw(double amount);
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance : {0}\nDeposit Amount: {1}", this.balance, amount);
                this.balance =this.balance + amount;
                Console.WriteLine("Current Balance: " + this.balance);
                this.transactions++;
            }
            else Console.WriteLine("Deposit Unsecessful......");
        }
        public abstract void Transfer(Account receiver, double amount);

        public void Show()
        {
            Console.WriteLine("Balance : " + this.balance);
            Console.WriteLine("Number of transactions : " + this.transactions);
        }
    }
}
