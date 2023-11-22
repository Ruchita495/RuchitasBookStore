using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RuchitasBookStore.Models.ViewModels;
using System.Diagnostics;
using RuchitasBookStore.Models;
using RuchitasBooks.DataAccess.Repository;
using System.Collections.Generic;
using RuchitasBooks.Models;

namespace RuchitasBookStore.Area.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UnitOfWork _unifOfWork;

        public HomeController(ILogger<HomeController> logger, UnitOfWork unifOfWork)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
