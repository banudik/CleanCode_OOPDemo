using CleanCode_OOPDemo.Business;
using CleanCode_OOPDemo.Entities;

IProductService productService = new ProductManager(new IsBankServiceAdapter());
productService.Sell(new Product { Id = 1, Name = "Laptop", Price = 1000 }, new Customer { Id = 1, Name = "Banu", IsStudent = true, IsOfficer = false });

