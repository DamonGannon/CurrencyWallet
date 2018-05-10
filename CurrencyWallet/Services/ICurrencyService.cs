using CurrencyWallet.Models;

namespace CurrencyWallet.Services
{
    public interface ICurrencyService
    {
        CurrencyRatesResultModel GetCurrencies();
    }
}