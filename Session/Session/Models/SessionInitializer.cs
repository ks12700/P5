using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Session2.Models
{
    public class SessionInitializer : DropCreateDatabaseIfModelChanges<SessionContext>
    {
        protected override void Seed(SessionContext context)
        {
            base.Seed(context);

            Session One = new Session()
            {
                Name = "Session 1"
            };
            Session Two = new Session()
            {
                Name = "Session 2"
            };
            Session Three = new Session()
            {
                Name = "Session 3"
            };

            context.Sessions.Add(One);
            context.Sessions.Add(Two);
            context.Sessions.Add(Three);

            context.SaveChanges();
        }
    }
}