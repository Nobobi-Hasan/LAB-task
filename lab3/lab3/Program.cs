using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Nobobi";
            s.Id = "18-38712-3";
            s.Department = "CSE";
            s.Cgpa = 3.82f;
            s.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Triangle t = new Triangle();
            t.X = 6;
            t.Y = 6;
            t.Z = 5;
            t.ShowInfo();
            t.TestTriangle();
            Console.WriteLine("----------------------------- ");

            Account a = new Account();
            a.AccName = "Nobobi Shatin";
            a.Acid = "n-73";
            a.Balance = 70000;
            a.ShowInfo();
            a.Deposit(15000);
            a.Withdraw(23000);
            Console.WriteLine("----------------------------- ");

            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseCode = "CSC 123";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }
}
