using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Cart
    {
        private Item[] item;

        public void AddtoCart(int id,string name,int qty)
        {
            Item It1 = new Item(id, name, qty);
           
        }
        public void RemoveFromCart(int id, string name, int qty)
        {
            Item It1 = new Item(id, name, qty);
        }
    }
}
