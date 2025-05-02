using System;

namespace encapsulation
{
    public class Data
    {
        private string name;
        private int rollno;
        private int marks;

        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        public void SetRollNo(int r)
        {
            rollno = r;
        }

        public int GetRollNo()
        {
            return rollno;
        }

        public void SetMarks(int m)
        {
            if (m >= 0 && m <= 100)
                marks = m;
            else
                Console.WriteLine("Invalid marks");
        }

        public int GetMarks()
        {
            return marks;
        }

        public void Display()
        {
            
            Console.WriteLine("name is " + name);
            Console.WriteLine("roll no is " + rollno);
            Console.WriteLine("marks are " + marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data s = new Data();
            s.SetName("Muhammad Irtaza Rizvi");
            s.SetRollNo(122);
            s.SetMarks(90);

            s.Display();

            Console.ReadKey();
        }
    }
}
