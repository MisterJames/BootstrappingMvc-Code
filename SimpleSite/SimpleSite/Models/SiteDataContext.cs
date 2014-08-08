using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleSite.Models
{
    public class SiteDataContext : DbContext
    {
        public SiteDataContext() : base("DefaultConnection") { }

        public DbSet<Notification> Notifications { get; set; }
    }
}