using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    class Account
    {
        private Transaction[] listOfTransaction;

        public string AccName { get; set; }

        public string AccNo { set; get; }

        public double Balance { get; set; }

        public int TotalNumberOfTransaction { set; get; }

        public Account()
        {
            listOfTransaction = new Transaction[10];
        }

        public Account(string accName, string accNo, double balance)
        {
            this.AccName = accName;
            this.AccNo = accNo;
            this.Balance = balance;
            listOfTransaction = new Transaction[10];
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
            Transaction t = new Transaction(this, this, amount, "Self Deposit");
            this.AddTransaction(t);
        }

        public void AddTransaction(Transaction t)
        {
            if (this.TotalNumberOfTransaction < 10)
            {
                this.listOfTransaction[this.TotalNumberOfTransaction++] = t;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: {0}", this.AccName);
            Console.WriteLine("Acc No: {0}", this.AccNo);
            Console.WriteLine("Balance: {0}", this.Balance);
        }

        public void Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                Transaction t = new Transaction(this, this, amount, "Self Withdraw");
                this.AddTransaction(t);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void Transfer(Account acc, double amount)
        {
            if (this.Balance - amount >= 0)
            {
                Transaction t1 = new Transaction(this, acc, amount, "Transfer");
                acc.Balance += amount;
                acc.AddTransaction(t1);

                this.Balance -= amount;
                this.AddTransaction(t1);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public void ShowAllTransaction()
        {
            for (int i = 0; i < this.TotalNumberOfTransaction; i++)
            {
                this.listOfTransaction[i].ShowInfo();
            }
        }
    }
}