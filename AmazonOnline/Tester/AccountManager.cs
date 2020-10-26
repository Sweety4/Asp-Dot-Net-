using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class AccountManager
    {
        public static Boolean Login(string username, string password)
        {
            if (username == "Sweety" && password == "Sweety")
            {
                return true;
            }
            else
                return false;
        }

        public static void Register(int id, string fname, string lname, string email, string mob)
        {
            Customer customer = new Customer(id, fname, lname, email, mob);

        }
        public static void ChangePassword(string username, string password)
        {


        }
    }
}
