using System;
namespace oop
{
    class book
    {
        public string bookname;
        public string author;
        public int pg;

        public void book1()
        {
            Console.WriteLine("name of book is " + bookname + " by " + author + " and pages are " + pg);
        }
        
    }
    class program
    {
        static void Main(string[] args)
        {
            book b = new book();
            b.bookname = "SHAYAD";
            b.author = "Jaun Elia";
            b.pg = 356;
            b.book1();
            Console.ReadKey();


        }

    }
}