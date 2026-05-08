using Microsoft.AspNetCore.Mvc;
using OnlineBankingMVCFiltersApp.Filters;

namespace OnlineBankingMVCFiltersApp.Controllers
{
    [ServiceFilter(typeof(AuthenticationFilter))]
    [ServiceFilter(typeof(LoggingFilter))]
    public class BankController : Controller
    {
        public IActionResult Dashboard()
        {
            return Content("Bank Dashboard");
        }

        public IActionResult Transactions()
        {
            return Content("Transaction History");
        }

        [ServiceFilter(typeof(AuthorizationFilter))]
        public IActionResult AdminPanel()
        {
            return Content("Admin Panel Access");
        }

        public IActionResult ErrorTest()
        {
            throw new Exception("Banking Exception");
        }
    }
}