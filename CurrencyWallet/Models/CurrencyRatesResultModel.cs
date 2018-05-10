using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWallet.Models
{
    public class CurrencyRatesResultModel
    {
        public string BaseCurrency { get; set; }
        public IEnumerable<CurrencyModel> Currencies { get; set; }
    }
}