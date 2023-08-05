using PostgreSqlWithEntityFrameWork.Data;
using PostgreSqlWithEntityFrameWork.Models;

AppDbContext context = new AppDbContext();

//          Listing Products

//foreach (var item in context.Products)
//{
//    Console.WriteLine(item.Id);
//    Console.WriteLine(item.Name);
//    Console.WriteLine(item.Description);
//    Console.WriteLine(item.Price);
//    Console.WriteLine(item.Stock);
//}

//          Adding Product

//context.Products.Add(new Product
//{
//    Id = 3,
//    Name = "Positive Cap",
//    Description = "Positive hat",
//    Price = 19,
//    Stock = 20,
//    CategoryId = 2
//});

//          Removing Product

// context.Products.Remove(context.Products.FirstOrDefault(p => p.Id == 3));

context.SaveChangesAsync();