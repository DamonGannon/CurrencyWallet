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
        private ICurrencyService _currencyService;

        public HomeController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public ActionResult Index()
        {
            var currencies = _currencyService.GetCurrencies();
            return View(currencies);
        }
    }
}