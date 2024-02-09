using CleanCode_OOPDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_OOPDemo.Business;

public class FakeBankService:IBankService
{
    public decimal ConvertRate (CurrencyRate currencyRate)
    {
        return currencyRate.Price / (decimal)5.30;
    }
}

public class CentralBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        CentralBankService centralBankService = new CentralBankService();
        return centralBankService.ConvertCurrency(currencyRate);
    }
}

//Merkez bankasının kodu gibi düşünelim. Değiştiremeyiz.
public class CentralBankService
{
    public decimal ConvertCurrency(CurrencyRate currencyRate)
    {
        return (currencyRate.Price / (decimal)5.28);
    }
}

public class IsBankServiceAdapter : IBankService
{
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
        IsBankService isBankService = new IsBankService();
        return isBankService.ConvertCurrency(currencyRate);
    }
}


//İş bankasının kodu gibi düşünelim.
public class IsBankService
{
    public decimal ConvertCurrency(CurrencyRate currencyRate)
    {
        return (currencyRate.Price / (decimal)5.25);
    }
}