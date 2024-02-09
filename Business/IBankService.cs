using CleanCode_OOPDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_OOPDemo.Business;

public interface IBankService
{
    decimal ConvertRate(CurrencyRate currencyRate);
}
