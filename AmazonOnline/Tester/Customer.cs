using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Customer
    {
        private int id;
        private string firstname;
        private string lastname;
        private string email;
        private string contactNumber;

        public int ID
        {
            get { return this.id; }
        }
        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string ContactNumber
        {
            get { return this.contactNumber; }
            set { this.contactNumber = value; }
        }
        public Customer() { }
        public Customer(int id, string firstname, string lastname, string email, string contactNumber)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.contactNumber = contactNumber;
        }
        public override string ToString()
        {


            return this.ID + " " + this.FirstName + " " + this.LastName + " " + this.email + " " + this.contactNumber;
        }
    }
}
