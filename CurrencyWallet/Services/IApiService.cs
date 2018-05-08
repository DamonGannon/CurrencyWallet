using CurrencyWallet.Models.ApiModels;

namespace CurrencyWallet.Services
{
    public interface IApiService
    {
        TOutput Get<TOutput>(IApiRequestModel request);
    }
}