using System;
namespace inheritance
{
    class vehicle
    {
        public void start()
        {
            Console.WriteLine("vehicle is starting");
        }
        public void stop()
        {
            Console.WriteLine("vehicle is stopped");
        }
    }
        class car : vehicle
        {
            public void drive()
            {
                Console.WriteLine("car is driving");
            }
        }
            class bike : vehicle
            {
                public void ride()
                {
                    Console.WriteLine("bike  is riding");
                }
            }
        
            class program
            {
                static void Main(string[] args)
                {
                    car c = new car();
                    c.start();
                    c.drive();
                    c.stop();
                    bike b=new bike();
                    b.start();
                    b.ride();
                    b.stop();

                }
            }   
}