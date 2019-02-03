using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practicing_AJAX_GoogleApi_ClickEvents.Models
{
    public class DbContextClass : DbContext
    {
        public DbContextClass() : base("name=ConStr")
        {

        }

        public DbSet<GoogleMapCord> GoogleMapCords { get; set; }


    }
}