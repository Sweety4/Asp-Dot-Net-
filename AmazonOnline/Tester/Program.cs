using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product(1, "Laptop", "HP", 45000, 4);
            Console.WriteLine(Product1);



            Customer C1 = new Customer(1, "Sweety", "Jangale", "Sweety@123", "9977664433");
            Console.WriteLine(C1);



            Account a1 = new Account();
            a1.deposit(200);
            a1.withdraw(100);
            Console.WriteLine("Total Balance {0} :", a1.Display());


            if (AccountManager.Login("Sweety", "Sweety"))
            {
                Console.WriteLine("Login successful !!!");

            }
            else
            {
                Console.WriteLine("Login Failed !!!");
            }


            Console.WriteLine("Enter ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Contact");
            string mob = Console.ReadLine();
            Console.WriteLine("Registered Successfully !!!"); 
            AccountManager.Register(id, fname, lname, email, mob);

            Item I1 = new Item(1, "Laptop", 4);
            Console.WriteLine(I1);



        }
    }
}

