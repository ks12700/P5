using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session2.Models
{
    public class SessionContext : DbContext
    {
        public DbSet<Session> Sessions { get; set; }

        public SessionContext()
        {
            Database.SetInitializer<SessionContext>(new SessionInitializer());
        }
    }
}