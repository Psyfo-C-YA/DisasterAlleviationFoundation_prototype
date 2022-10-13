using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisasterAlleviationFoundation.Models
{
    [Table("Disaster")]
    public class Disaster
    {
        [Key]
        public int DisasterId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; } 
        public string Location { get; set; }
        public string Description { get; set; }
        public string RequiredAid { get; set; }

    }
}
