using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account("Mahfuza", "19-39398-1", 3000);
            var a2 = new Account("Jui", "39398", 5000);

            a1.Deposit(10000);
            a1.Withdraw(5000);
            a1.Transfer(a2, 4000);

            Console.WriteLine("\n        Account Balance         \n");

            a1.ShowInfo();
            a2.ShowInfo();

            Console.WriteLine("\n      Account Transactions List       \n");

            a1.ShowAllTransaction();
            a2.ShowAllTransaction();
        }
    }
}