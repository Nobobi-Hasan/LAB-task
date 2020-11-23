using System;

namespace Abstruct_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Abstruction LAB...");
            Console.WriteLine("");

            Account a1 = new Fixed("FA", "a01", 5000.00, 2020, 5);
            Account a2 = new Savings("SA", "a02", 7000.00, 10);
            Account a3 = new SpecialSavings("SSA", "a03", 10000.00, 5);
            Account a4 = new Overdraft("OA", "a04", 13000.00, 2000.00);


            a1.Withdraw(500);
            a2.Withdraw(500);
            a3.Withdraw(500);
            a4.Withdraw(500);

            Console.WriteLine("");

            a1.Withdraw(5000);
            a2.Withdraw(50000);
            a3.Withdraw(8000);
            a4.Withdraw(15000);

        }
    }
}
