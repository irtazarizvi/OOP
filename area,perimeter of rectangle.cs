using System;
namespace rectangle
{
    class lw
    {
        public double length;
        public double width;

        public void area()
        {
            Console.WriteLine("area is :" + (length * width));
        }
        public void perimeter()
        {
            Console.WriteLine("perimeter is :" + (2 * (length + width)));
        }
    }
    class program
    {
        static void Main(String[] args)
        {
            lw a = new lw();
            a.width = 12.5;
            a.length = 34.5;
            a.area();
            a.perimeter();
            Console.ReadKey();

        }
    }
}