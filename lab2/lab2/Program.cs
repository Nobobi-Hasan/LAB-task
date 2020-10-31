using System;

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

            /*int x = 0;
            for (int i = 0; i< 4; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    x = i + j;
                    if (x % 2 == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }*/

            //ques 3---------------------------------------

            /*for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j < i + 5; j++)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
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

            //ques 5---------------------------------------

            /*for (int i = -1; i <= 3; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i+2);
            }*/

            //ques 6---------------------------------------

            {
                int i;
                int b = 8, a = 32;
                for (i = 0; i <= 10; i++)
                {
                    if ((a / b * 2) == 2)
                    {
                        Console.WriteLine(i + " ");
                        continue;
                    }
                    else if (i != 4)
                        Console.Write(i + " ");
                    else
                        break;
                }
                Console.ReadLine();
            }

            //ques 7---------------------------------------

            /*for (int i = 0; i < 5; i++)
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
            }*/


        }
    }
}
