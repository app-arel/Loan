namespace Loan.Models
{
    public class LoanViewModel
    {
        public double Amount { get; set; }
        public double AmountToPay { get; set; }
        public double MonthlyPayment { get; set; }
        public double Interest { get; set; }
        public int Tenure { get; set; }
    }
}
