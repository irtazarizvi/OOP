using System;
namespace car
{
    class car1
    {
        public string brand;
        public int model;
        public float price;

        public void detail()
        {
            Console.WriteLine("brand={0} model={1} price={2}", brand, model, price);
        }
    }

    class c
    {
        static void Main(string[] args)
        {
            car1 c = new car1();
            c.brand = "toyota";
            c.model = 2022;
            c.price = 350000.0F;

            c.detail();
        }
    }
}
