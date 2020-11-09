using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Library
    {
        private string libName;

        public string LibName
        {
            get { return libName; }
            set { libName = value; }
        }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }

        private Book[] listOfBook;

        public Book[] ListOfBook
        {
            get { return listOfBook; }
            set { listOfBook = value; }
        }



        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }

        private Book[] books;

        public Book[] Books
        {
            get { return books; }
            set { books = value; }
        }

        private Account[] lAccount;

        public Account[] LAccount
        {
            get { return lAccount; }
            set { lAccount = value; }
        }

        public Library()
        {
            books = new Book[50000];
            lAccount =new Account[1];
        }

        public Library(string libName, string libAddress, int totalBook)
        {
            books = new Book[50000];
            lAccount = new Account[1];
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
        }


        public void ShowLibInfo()
        {
            Console.WriteLine("Library Name: " + libName);
            Console.WriteLine("Library Address: " + libAddress);
            Console.WriteLine("Total books: " + totalBook);
        }

        public void ShowAllBooks()
        {
            for(int i=0; i< books[].length(); i++ )
            {
                books[i].ShowInfo();
            }
            
        }

        public void AddNewBook(Book book)
        {
            
        }
    }
}
