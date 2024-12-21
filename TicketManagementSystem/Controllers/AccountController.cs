using Microsoft.AspNetCore.Mvc;

namespace TicketManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}