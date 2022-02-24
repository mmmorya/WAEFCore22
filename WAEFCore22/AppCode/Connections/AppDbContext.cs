using Microsoft.EntityFrameworkCore;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.Connections
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student_Db> tbl_Student { get; set; }
        public DbSet<Department_Db> tbl_Department { get; set; }
        public DbSet<Student_Db> proc_GetStudent { get; set; }

    }
}
