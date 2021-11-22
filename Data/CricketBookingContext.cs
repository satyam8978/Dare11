using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CricketBooking.Data
{
    public class CricketBookingContext : DbContext
    {
       
    
        public CricketBookingContext() : base("name=CricketBookingContext")
        {
        }

        public DbSet<Models.location> locations { get; set; }
        public DbSet<Models.venue> venues { get; set; }

        public System.Data.Entity.DbSet<CricketBooking.Models.Tournments> Tournments { get; set; }
    }
}
