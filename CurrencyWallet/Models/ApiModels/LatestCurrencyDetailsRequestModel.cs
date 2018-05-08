using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyWallet.Models.ApiModels
{
    public class LatestCurrencyDetailsRequestModel : BaseRequestModel, IApiRequestModel
    {
        public string Endpoint { get
            {
                return "latest";
            }
        }
    }
}