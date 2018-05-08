using CurrencyWallet.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace CurrencyWallet.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        private const string currencyUrl = "http://data.fixer.io/api/";
        private const string ApiKey = "a8ece45e2d36555359d8a61545886b1b";

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(currencyUrl);
        }

        public TOutput Get<TOutput>(IApiRequestModel request)
        {
            var response = _httpClient.GetAsync($"{request.Endpoint}?access_key=a8ece45e2d36555359d8a61545886b1b").Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<TOutput>().Result;
            }
            else
            {
                throw new Exception($"failed to call endpoint: {request.Endpoint}");
            }
        }

    }
}