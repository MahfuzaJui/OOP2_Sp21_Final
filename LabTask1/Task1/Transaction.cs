using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Transaction
    {
        public Account Sender { get; set; }

        public Account Receiver { get; set; }

        public double Amount { get; set; }

        public string AdditionalInfo { get; set; }

        public Transaction() { }

        public Transaction(Account sender, Account receiver, double amount, string additionalInfo)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Amount = amount;
            this.AdditionalInfo = additionalInfo;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Sender: {0}", this.Sender.AccName);
            Console.WriteLine("Receiver: {0}", this.Receiver.AccName);
            Console.WriteLine("Amount: {0}", this.Amount);
        }
    }
}