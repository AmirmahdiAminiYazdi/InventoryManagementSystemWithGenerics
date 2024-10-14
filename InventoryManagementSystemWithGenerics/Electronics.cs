using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemWithGenerics
{
    // Electronics class inheriting from Product
    public class Electronics : Product
    {
        public string Brand { get; set; } // Brand of the electronics
        public Electronics(string name, decimal price, int quantity, string brand) : base(name, price, quantity)
        {
            Brand = brand;
        }
        // Override ToString method to display electronics details
        public override string ToString() => $"{base.ToString()},Brand:{Brand}";
        
            
        
    }
}
