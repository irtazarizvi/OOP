using System;

namespace oop
{
    class BankBalance
    {
        public int acc_no;
        public double balance;

        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited successfully: " + amount);
        }

        public void withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdraw successfully: " + amount);
            }
            else
            {
                Console.WriteLine("lack of balance");
            }
        }

        public void display_balance()
        {
            Console.WriteLine("Current balance is: " + balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankBalance s = new BankBalance();
            s.acc_no = 123;
            s.balance = 1000;

            s.display_balance();
            s.deposit(500);
            s.withdraw(200);
            s.withdraw(2000);
            s.display_balance();

            Console.ReadKey();
        }
    }
}

