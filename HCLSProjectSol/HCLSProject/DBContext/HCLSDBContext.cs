using HCLSProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HCLSProject.DBContext
{
    public class HCLSDBContext : DbContext 
    {
        public HCLSDBContext(DbContextOptions <HCLSDBContext> options ) : base( options) { }

        public DbSet<AdminTypes >AdminTypes {  get; set; }

        public DbSet <Admin>Admins { get; set; }
    }
}
