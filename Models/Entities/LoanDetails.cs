using System.ComponentModel.DataAnnotations.Schema;

namespace Loan.Models.Entities
{
    public class LoanDetails
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public double AmountToPay { get; set; }
        public double MonthlyPayment { get; set; }
        public double Interest { get; set; }
        public int Tenure { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }  
    }
}
