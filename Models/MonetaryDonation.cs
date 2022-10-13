using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterAlleviationFoundation.Models
{
    [Table("Money")]
    public class MonetaryDonation
    {
        [Key]
        public int MonetaryDonationID { get; set; }
        [ForeignKey("User")]
        public int FKUserID { get; set; }
        public int Amount { get; set; } 
        public string  Date  { get; set; }
        public string? Donor { get; set; }
    }
}
