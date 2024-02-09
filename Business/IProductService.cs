using CleanCode_OOPDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_OOPDemo.Business;

public interface IProductService
{
    public void Sell(Product product, Customer customer);
}
