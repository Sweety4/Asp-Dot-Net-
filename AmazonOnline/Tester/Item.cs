using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Item
    {
        private int id;
        private string product;
        private int quantity;

        public int ID
        {
            get { return this.id; }
        }
        public string Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public Item() { }
        public Item(int id, string product, int quantity)
        {
            this.id = id;
            this.Product = product;
            this.Quantity = quantity;

        }
        public override string ToString()
        {


            return this.ID + " " + this.Product + " " + this.quantity;
        }
    }
}
