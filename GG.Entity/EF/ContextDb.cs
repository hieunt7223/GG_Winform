using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace GG.Entity
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Studio
            modelBuilder.ApplyConfiguration(new SystemsConfiguration());
            modelBuilder.ApplyConfiguration(new ModulesConfiguration());
            modelBuilder.ApplyConfiguration(new ConfigColumnsConfiguration());
            modelBuilder.ApplyConfiguration(new ConfigValuesConfiguration());
            modelBuilder.ApplyConfiguration(new FieldColumnsConfiguration());
            #endregion
        }

        #region Studio
        public DbSet<Systems> Systems { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<ConfigColumns> ConfigColumns { get; set; }
        public DbSet<ConfigValues> ConfigValues { get; set; }
        public DbSet<FieldColumns> FieldColumns { get; set; }
        #endregion

    }

}
