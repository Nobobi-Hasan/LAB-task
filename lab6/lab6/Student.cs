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

        private Account[] sAccount;

        public Account[] SAccount
        {
            get { return sAccount; }
            set { sAccount = value; }
        }

        private int borrowBookCount;
        public int BorrowBookCount
        {
            get { return borrowBookCount; }
            set { borrowBookCount = value; }
        }

        private Book[] borrow;

        public Book[] Borrow
        {
            get { return borrow; }
            set { borrow = value; }
        }

        public void BorrowBook(Book book, int copy, String name)
        {
            Console.WriteLine(copy +" " +book.BookName + " books borrowed by "+ name );
            borrow[borrowBookCount++] = book;
            book.RemoveBookCopy(copy);
        }


        public Student()
        {
            Borrow = new Book[5];
            sAccount = new Account[1];
        }

        public Student(string name, string id, string department, float cgpa)
        {
            Borrow = new Book[5];
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
            sAccount = new Account[1];
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("CGPA : " + cgpa);
        }

        public void ShowBorrowedBooks()
        {
            Console.WriteLine("Borrowed book information: ");
            for (int i = 0; i < borrowBookCount; i++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Book " + (i + 1) + " in borrow:");
                Console.WriteLine("Book Name: " + borrow[i].BookName);
                Console.WriteLine("Book Author: " + borrow[i].BookAuthor);
                Console.WriteLine("Book Id: " + borrow[i].BookId);
                Console.WriteLine("Book Type: " + borrow[i].BookType);
                Console.WriteLine("Book Copy left: " + borrow[i].BookCopy);
                Console.WriteLine(" ");
            }
        }

    }
}
