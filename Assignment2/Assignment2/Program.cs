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
                        int src = 0;

                        while (true)
                        {
                            Console.Write("savings : Open a savings account\nchecking : Open a checking account\nquit : Exit the application\nInput Your choice : ");
                            string inp = Console.ReadLine();
                            switch (inp)
                            {
                                case "savings":
                                    Console.Write("Enter Account : \nName : ");
                                    string name = Console.ReadLine();
                                    Console.Write("Date of Birth : ");
                                    string dob = Console.ReadLine();
                                    Console.Write("Balance : ");
                                    double balance = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Address :\nRoad No. : ");
                                    string r = Console.ReadLine();
                                    Console.Write("House No. : ");
                                    string h = Console.ReadLine();
                                    Console.Write("City : ");
                                    string c = Console.ReadLine();
                                    Console.Write("Country : ");
                                    string co = Console.ReadLine();
                                    int id = AutoIdGenerator();
                                    Account a1;
                                    a1 = new SavingAccount(id,name, dob, balance, new Address(r, h, c, co));
                                    bank.AddAccount(a1);
                                    break;
                                case "checking":
                                    Console.Write("Enter Account : \nName : ");
                                    string name1 = Console.ReadLine();
                                    Console.Write("Date of Birth : ");
                                    string dob1 = Console.ReadLine();
                                    Console.Write("Balance : ");
                                    double balance1 = Convert.ToDouble(Console.ReadLine());
                                    Console.Write("Address :\nRoad No. : ");
                                    string r1 = Console.ReadLine();
                                    Console.Write("House No. : ");
                                    string h1 = Console.ReadLine();
                                    Console.Write("City : ");
                                    string c1 = Console.ReadLine();
                                    Console.Write("Country : ");
                                    string co1 = Console.ReadLine();
                                    int id1 = AutoIdGenerator();
                                    Account a2;
                                    a2 = new SavingAccount(id1, name1, dob1, balance1, new Address(r1, h1, c1, co1));
                                    bank.AddAccount(a2);
                                    break;
                                case "quit":
                                    src = 1;
                                    break;
                                default:
                                    break;
                            }
                            if (src == 1) break;

                        }

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
