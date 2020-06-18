using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
    /// <summary>
    /// Generated Configuration for Table : STModules.
    /// </summary>
    public class STModulesConfiguration : IEntityTypeConfiguration<STModules>
    {
        public void Configure(EntityTypeBuilder<STModules> builder)
        {
            #region Generated Configuration By Column

            builder.ToTable("STModules");

            builder.HasKey(s => s.STModuleID);

            builder.Property(x => x.STModuleID).UseIdentityColumn();

            builder.Property(s => s.AAStatus).HasMaxLength(10);

            builder.Property(s => s.STModuleNo).IsRequired().HasMaxLength(100);

            builder.Property(s => s.STModuleName).HasMaxLength(500);

            builder.Property(s => s.STModuleType).HasMaxLength(100);

            builder.Property(s => s.STModuleCode).HasMaxLength(500);

            builder.Property(s => s.STModuleLink).HasMaxLength(500);

            #endregion
        }
    }
}