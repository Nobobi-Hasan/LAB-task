using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s =  new Student("Shatin", "18-38712-3", "CSE", 3.82f);
            s.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Student r = new Student("Ratin", "18-38737-3", "CSE", 2.82f);
            r.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Book b = new Book("Tin Goenda", "Qazi Anwar Hussain", "3-b1", "spy-thriller", 25);
            b.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Book b2 = new Book("Treasure Hunter", "Qazi Anwar Hussain", "3-b2", "spy-thriller", 18);
            b2.ShowInfo();
            Console.WriteLine("----------------------------- ");

            b2.AddBookCopy(10);
            b2.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Account sa = new Account("shaAcc", "sS001", 5000);
            sa.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Account la = new Account("libAcc", "lL002", 25000);
            la.ShowInfo();
            Console.WriteLine("----------------------------- ");

            Library l = new Library("Moyez Uddin Library", "Kuthibari Kamlapur, Faridpur", 30000);
            l.ShowLibInfo();
            Console.WriteLine("----------------------------- ");

            

            
            l.AddNewBook(b);
            l.AddNewBook(b2);
            //l.DeleteBook(b);
            l.ShowAllBooks();
            l.AddNewBookCopy(b,58);
            l.AddNewBookCopy(b2,77);
            l.ShowAllBooks();

            s.BorrowBook(b,2,"Shatin");
            r.BorrowBook(b2,3, "Ratin");
            l.ShowAllBooks();
            s.ShowBorrowedBooks();
            r.ShowBorrowedBooks();
        }
    }
}
