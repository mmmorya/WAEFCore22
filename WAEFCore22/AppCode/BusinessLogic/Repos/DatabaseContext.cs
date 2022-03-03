using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WAEFCore22.AppCode.Interface.Repos;

namespace WAEFCore22.AppCode.BusinessLogic.Repos
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext() : base("OrganizationDb")
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add your model configuration here
        }
    }
}
