using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWallet.Models.ApiModels
{
    public class LatestCurrencyDetailsResponseModel
    {
        public string Base { get; set; }
        public Dictionary<string, decimal> rates { get; set; }
    }
}