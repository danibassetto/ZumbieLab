using ZumbieLab.Map;
using ZumbieLab.Models;
using Microsoft.EntityFrameworkCore;

namespace ZumbieLab.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }

        public DbSet<UserModel> User { get; set; }
        public DbSet<HostModel> Host { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new HostMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}