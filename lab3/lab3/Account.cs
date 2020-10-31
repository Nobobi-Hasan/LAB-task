using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Account
    {
        string accName;
        string acid;
        int balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }

        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("A/C Id: " + acid);
            Console.WriteLine("Primary balance: " + balance);
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Balance after deposite: " + balance);
        }

        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Balance after withdraw: " + balance);
        }
    }
}
