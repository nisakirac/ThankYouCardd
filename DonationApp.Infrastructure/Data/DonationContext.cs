using DonationApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DonationApp.Infrastructure.Data
{
    
        public class DonationContext : DbContext
        {
            public DonationContext(DbContextOptions<DonationContext> options)
                : base(options)
            {
            }

            public DbSet<Donor> Donors { get; set; }
            public DbSet<ThankYouCard> ThankYouCards { get; set; }
        }
    }


