using Microsoft.AspNetCore.Mvc;
using TicketManagementSystem.Models;
using TicketManagementSystem.Repository.Interfaces;

namespace TicketManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserManagementController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserManagementController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            var model = _userRepository.GetUsers().ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            User user = new User();
            return View(user);
        }

        [HttpPost("Create")]
        public IActionResult Create(User UserModel)
        {
            return null;
        }
    }
}