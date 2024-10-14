using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemWithGenerics
{
    // Base product class that all products inherit from
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }


        protected Product(string name , decimal price , int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        // Override ToString method to display product details
        public override string ToString()=> $"{Name} - ${Price} ({Quantity} available)";

    }
}
