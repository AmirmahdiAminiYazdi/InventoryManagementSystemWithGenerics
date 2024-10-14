using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystemWithGenerics
{
    // Generic Inventory class for managing products
    public class Inventory<T> where T : Product  // Generic class with constraint that T must be a Product or its subclass
    {
        private readonly List<T> _items = new List<T>(); // List to hold the inventory items
        public static int TotalItems {  get; private set; } = 0; // Static member to track total number of items in the inventory


        // Method to add an item to the inventory
        public void AddItem(T item)
        {
            _items.Add(item);
            TotalItems += item.Quantity;
        }
        // Method to remove an item from the inventory
        public void RemoveItem(T item) 
        { 
            _items.Remove(item);
            TotalItems -= item.Quantity;
        }
        // Method to display the inventory of a specific product type
        public void DisplayInventory()
        {
            Console.WriteLine($"Inventory for {typeof(T).Name}");
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        // Generic method to create a default item (used for default values)
        public static T CreateDefaultItem()
        {
            return default(T); // Return the default value for the generic type T
        }

        }
    }
