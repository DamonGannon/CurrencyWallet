using CurrencyWallet.Models.ApiModels;
using CurrencyWallet.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurrencyWallet.Controllers
{
    public class HomeController : Controller
    {
        private IApiService _apiService;

        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public ActionResult Index()
        {
            var test =_apiService.Get<LatestCurrencyDetailsResponseModel>(new LatestCurrencyDetailsRequestModel());

            return View();
        }
    }
}