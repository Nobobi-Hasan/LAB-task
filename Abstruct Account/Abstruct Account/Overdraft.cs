using System;
using System.Collections.Generic;
using System.Text;

namespace Abstruct_Account
{
    class Overdraft:Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }


        public Overdraft()
        {

        }

        public Overdraft(string accName, string accNo, double balance, double overdraftLimit) : base(accName, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {

            if (amount <= Balance+overdraftLimit)
            {
                Balance -= amount;

            }

        }

    }
}
