using CleanCode_OOPDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_OOPDemo.Business;

public class ProductManager : IProductService
{
    private IBankService _bankService;

    public ProductManager(IBankService bankService)
    {
        _bankService = bankService;
    }

    public void Sell(Product product, Customer customer)
    {
        //refactor olacak (unutma!)
        decimal price = product.Price;
        if (customer.IsStudent)
        {
            price = product.Price * (decimal)0.90;
        }
        if (customer.IsOfficer)
        {
            price = product.Price * (decimal)0.80;
        }
        
        price = _bankService.ConvertRate(new CurrencyRate { Currency = 1, Price = price });
        Console.WriteLine(price);
        Console.ReadLine();
    }
}
