using System;
namespace encapsulation2
{
    class Student
    {
        private string name;
        public void SetName(string n)
        {
            if (string.IsNullOrWhiteSpace(n))
                Console.WriteLine("invalid name");
            else
                name = n;
        }
        public string GetName()
        {
            return name;
        }
        public void Display()
        {
            Console.WriteLine("name is " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetName("irtaza rizvi");    
            s.Display();
            Console.ReadKey();
       
        
        }
    }
                  
                     
}
