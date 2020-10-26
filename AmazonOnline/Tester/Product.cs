using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Product
    {
        private int id;
        private string title;
        private string description;
        private float unitPrice;
        private int quantity;

        public int ID
        {
            get { return this.id; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public float UnitPrice
        {
            get { return this.unitPrice; }
            set { this.unitPrice = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

        public Product() { }
        public Product(int id, string title, string description, float unitPrice, int quantity)
        {
            this.id = id;
            this.Title = title;
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.quantity = quantity;
        }
        public override string ToString()
        {


            return this.ID + " " + this.Title + " " + this.Description + " " + this.UnitPrice + " " + this.Quantity;
        }
    
    }
}
