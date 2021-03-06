using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static int id = 0;

        public static int AutoIdGenerator()
        {
            id++;
            return id;
        }

        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int check = 0;


            while (true)
            {
        
                Console.Write("open : Open a Bank account\naccount : Perform transactions on an account\nquit : Exit the application\nInput Your choice : ");
                string x = Console.ReadLine();

                switch (x)
                {
                    case "open":

                        break;
                    case "account":
                        break;
                    case "quit":
                        check = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
                if (check == 1) break;
            }
        }
    }
}
