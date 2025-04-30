using System;
namespace oop
{
    class speedcar
    {
        public string model;
        public string brand;
        public int year;
        public int speed = 0;
        public void accelerate(int amount)
        {
            speed += amount;

        }
        public void Break(int amount)
        {
            speed -= amount;
            if (speed < 0)
            {
                speed = 0;
            }
        }
            public void display() { 
        {
                Console.WriteLine("brand is "+brand+"model is "+model+" year is "+year)
                Console.WriteLine("the current speed is " + speed);

        } 
          
        }
    static void Main(string[] args)
        {
            speedcar s = new speedcar();
            s.brand = "toyota";
            s.model = "2025";
            s.year = 2022;

            s.accelerate(50);
            s.Break(30);
            s.display();
            Console.ReadKey();


        }
    }
}
