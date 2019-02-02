using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ZeroApp1.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
            : base("ZeroCon")
        {
            DropCreateDatabaseIfModelChanges<UserContext> d = new DropCreateDatabaseIfModelChanges<UserContext>();
                Database.SetInitializer<UserContext>(d);
                }
        public DbSet<user> users { get; set; }

        public System.Data.Entity.DbSet<ZeroApp1.Models.student> students { get; set; }
    }
}