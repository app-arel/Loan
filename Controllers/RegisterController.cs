using Loan.Data;
using Loan.Models;
using Loan.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loan.Controllers
{
    public class RegisterController : Controller
    {
        private readonly LoanContext dbContext;

        public RegisterController(LoanContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserViewModel viewModel)
        {
            var user = new User
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                BVN = viewModel.BVN,
                Address = viewModel.Address,
                Age = viewModel.Age,
                Date = viewModel.Date,
            };
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return View("Loan"); 
        }
    }
}
