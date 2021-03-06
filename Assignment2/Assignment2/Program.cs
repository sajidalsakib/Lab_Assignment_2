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
        }
    }
}
