using System;
using System.Runtime.InteropServices.ComTypes;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2");
            Console.WriteLine("");

            //ques 1---------------------------------------

            /*Console.WriteLine("Even number from 0 to 30: ");
            for (int i = 0; i <= 30; i++)
            {
                if(i%2==0)
                {
                    Console.Write(i+(" "));
                }
                
            }*/


            //ques 2---------------------------------------

            /*for (int i = 1; i <=4; i++)
            {
                for (int j = 1;  j<= 3; j++)
                {
                    Console.Write("XO");

                }
                Console.WriteLine("");
            }*/

            //ques 3---------------------------------------

            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < i + 5; j++)
                {
                    Console.Write(j);

                }
            }*/

            //ques 4---------------------------------------

            /*int a=0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    a =a + i;

                }

            }
            Console.WriteLine("Sum of odd:"+ a);

            int b = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    b = b + i;

                }

            }
            Console.WriteLine("Sum of Even:" + b);*/

            //ques 7---------------------------------------

            for (int i = 0; i < 5; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


            for (int k = 5; k >=0; k--)
            {
                for (int l = k; l >= 0; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }


        }
    }
}
