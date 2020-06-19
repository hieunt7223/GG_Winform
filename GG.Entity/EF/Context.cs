using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace GG.Entity
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ST
            modelBuilder.ApplyConfiguration(new STSystemsConfiguration());
            modelBuilder.ApplyConfiguration(new STModulesConfiguration());
            #endregion

            #region AD
            modelBuilder.ApplyConfiguration(new ADConfigColumnsConfiguration());
            modelBuilder.ApplyConfiguration(new ADConfigValuesConfiguration());
            modelBuilder.ApplyConfiguration(new ADFieldColumnsConfiguration());
            #endregion
        }

        #region ST
        public DbSet<STSystems> STSystems { get; set; }
        public DbSet<STModules> STModules { get; set; }
        #endregion

        #region AD
        public DbSet<ADConfigColumns> ADConfigColumns { get; set; }
        public DbSet<ADConfigValues> ADConfigValues { get; set; }
        public DbSet<ADFieldColumns> ADFieldColumns { get; set; }
        #endregion
    }

}
