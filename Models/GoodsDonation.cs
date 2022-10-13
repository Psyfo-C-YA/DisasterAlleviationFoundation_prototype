using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterAlleviationFoundation.Models
{
    [Table("Goods")]
    public class GoodsDonation
    {
        [Key]
        public int GoodsDonationId { get; set;}
        [ForeignKey("User")]
        public int FKUserID { get; set; }
        public int NumberItems { get; set;} 
        public string Category { get; set;}
        public string Description { get; set;}    
        public string? Donor { get; set;}
    }
}
