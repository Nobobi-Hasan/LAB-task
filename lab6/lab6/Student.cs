using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;




        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        private Account accounts;

        public Account Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }


        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }

    }
}
