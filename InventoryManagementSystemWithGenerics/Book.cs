namespace InventoryManagementSystemWithGenerics
{
    // Book class inheriting from Product
    public class Book : Product
    {
        public string Author { get; set; }

        public Book(string name, decimal price, int quantity, string author)
            : base(name, price, quantity)
        {
            Author = author;
        }
        // Override ToString method to display book details
        public override string ToString() => $"{base.ToString()}, Author: {Author}";
    }
}
