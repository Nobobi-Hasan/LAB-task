using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Account
{
    class SpecialSavings:Account
    {

        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transCount;

        public int TransCount
        {
            get { return transCount; }
            set { transCount = value; }
        }


        public SpecialSavings()
        {

        }

        public SpecialSavings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
        }

        public override void Withdraw(double amount)
        {
            transCount++;
            if ((transCount <= transactionNo) && (Balance - amount >= (OpeningBalance/5)))
            {
                Balance -= amount;
            }
            else
            {
                if (transCount > transactionNo)
                {
                    Console.WriteLine("Minimal number of transaction reached.");
                }

                else
                    Console.WriteLine("Insufficient Balance");
            }

        }

    }
}
