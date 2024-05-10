using Google.Protobuf.WellKnownTypes;
using System.ComponentModel.DataAnnotations;

namespace Loan.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BVN { get; set; }
        public string Address {  get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
    }
}
