using Google.Protobuf.WellKnownTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loan.Models.Entities
{
    [Index("Email", IsUnique = true)]
    [Index("BVN", IsUnique = true)]
    [Index("Phone", IsUnique = true)]
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string BVN { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }

    }
}
