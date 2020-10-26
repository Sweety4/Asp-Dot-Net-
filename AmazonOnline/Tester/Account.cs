using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Account
    {
        private float balance;

        public Account()
        {
            this.balance = 0000;
        }

        public float withdraw(float amount)
        {
            this.balance = this.balance - amount;
            return amount;

        }

        public float deposit(float amount)
        {
            this.balance = this.balance + amount;
            return amount;

        }
        public float Balance
        {
            get { return this.balance; }
            set { this.balance = value; }

        }

        public Account(float balance)
        {
            this.Balance = balance;
        }

        public float Display()
        {
            return this.Balance;
        }

    }
}
