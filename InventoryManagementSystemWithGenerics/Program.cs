using InventoryManagementSystemWithGenerics;

var electronicsInventory = new Inventory<Electronics>();
electronicsInventory.AddItem(new Electronics("Laptop", 1200.00m, 5, "Dell"));
electronicsInventory.AddItem(new Electronics("Smartphone", 800.00m, 10, "Samsung"));

var bookInventory = new Inventory<Book>();
bookInventory.AddItem(new Book("C# Programming", 29.99m, 15, "John Doe"));
bookInventory.AddItem(new Book("Mastering ASP.NET", 39.99m, 8, "Jane Smith"));

electronicsInventory.DisplayInventory();
bookInventory.DisplayInventory();

Console.WriteLine($"\nTotal Items in Inventory: {Inventory<Electronics>.TotalItems + Inventory<Book>.TotalItems}");

var defaultElectronics = Inventory<Electronics>.CreateDefaultItem();
Console.WriteLine($"\nDefault Electronics Item: {defaultElectronics?.ToString() ?? "No default value for Electronics."}");

Console.ReadKey();