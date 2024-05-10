using Loan.Data;
using Loan.Models.Entities;
using Loan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Loan.Controllers
{
    public class LoanController : Controller
    {
        private readonly LoanContext context;

        public LoanController(LoanContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Loan()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Loan(LoanViewModel vModel)
        {
            var interest = 1.10;
            var amountToPay = vModel.Amount * (1.10 * vModel.Tenure);
            var monthlyPayment = amountToPay / 12;
            var loan = new LoanDetails
            {
                Amount = vModel.Amount,
                Tenure = vModel.Tenure,
                AmountToPay = amountToPay,
                Interest = interest,
                MonthlyPayment = monthlyPayment
            };
            context.loans.Add(loan);
            context.SaveChanges();
            return View("Loan");
        }
    }
}
