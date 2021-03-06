using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bank
    {
        private Account[] myBank = new Account[100];

        public Bank()
        {

        }
        public Account[] MyBank
        {
            get { return this.myBank; }
        }
        public void AddAccount(Account account)
        {
            int check = 0 ;
            int num = -1;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    check = 1;
                    num = i;
                    break;
                }
            }
            if (check == 1) Console.WriteLine("Account Opened....\nYour Account Number = {0} ", myBank[num].AccountNumber);
            else Console.WriteLine("Can not open your account.....");
        }

        public void Transaction(string transactionType, params object[] obj)
        {
            int accountNumber = Convert.ToInt32(obj[0]);
            double amount = Convert.ToSingle(obj[1]);
            int findAcc = -1;
            for(int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) continue;
                if(accountNumber == myBank[i].AccountNumber)
                {
                    findAcc = i;
                    break;
                }
            }
            if (findAcc == -1)
            {
                Console.WriteLine("Invalid Account Number......");
            }
            else
            {
                if (transactionType == "withdraw")
                {
                    myBank[findAcc].Withdraw(amount);
                }
                else if (transactionType == "deposit")
                {
                    myBank[findAcc].Deposit(amount);
                }
                else if (transactionType == "transfer")
                {
                    int receverAcc = -1;
                    int recAccount = Convert.ToInt32(obj[2]);
                    for (int j = 0; j < myBank.Length; j++)
                    {
                        if (myBank[j] == null) continue;
                        if ( recAccount== myBank[j].AccountNumber)
                        {
                            receverAcc = j;
                            break;
                        }
                    }

                    if(receverAcc == -1) Console.WriteLine("Invalid Receiver Account Number......");
                    else if(receverAcc == findAcc) Console.WriteLine("Both Account Number Are same......");
                    else
                    {
                        myBank[findAcc].Transfer(myBank[receverAcc], amount);
                    }
                }
            }
            
        }
        
        public void AccountDetails(int f)
        {
            int q = -1; 
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) continue;
                if (f == myBank[i].AccountNumber)
                {
                    q = i;
                    break;
                }
            }

            if (q == -1) Console.WriteLine("Invalid Account Number");
            else  myBank[q].Show();
        }
    }
}
