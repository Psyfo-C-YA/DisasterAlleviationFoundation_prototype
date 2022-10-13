using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DisasterAlleviationFoundation.Models;

namespace DisasterAlleviationFoundation_prototype.Data
{
    public class DisasterAlleviationFoundation_prototypeContext : DbContext
    {
        public DisasterAlleviationFoundation_prototypeContext (DbContextOptions<DisasterAlleviationFoundation_prototypeContext> options)
            : base(options)
        {
        }

        public DbSet<DisasterAlleviationFoundation.Models.Disaster> Disasters { get; set; }

        public DbSet<DisasterAlleviationFoundation.Models.GoodsDonation> GoodsDonations { get; set; }

        public DbSet<DisasterAlleviationFoundation.Models.MonetaryDonation> MonetaryDonations { get; set; }

        public DbSet<DisasterAlleviationFoundation.Models.User> Users { get; set; }
    }
}
