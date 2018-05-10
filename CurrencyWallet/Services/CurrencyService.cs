using CurrencyWallet.Models;
using CurrencyWallet.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWallet.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IApiService _apiService;

        public CurrencyService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public CurrencyRatesResultModel GetCurrencies()
        {
            var apiResult = _apiService.Get<LatestCurrencyDetailsResponseModel>(new LatestCurrencyDetailsRequestModel());

            return new CurrencyRatesResultModel
            {
                BaseCurrency = apiResult.Base,
                Currencies = apiResult.Rates.Select(x => new CurrencyModel { Currency = x.Key, Rate = x.Value })
            };
        }
    }
}