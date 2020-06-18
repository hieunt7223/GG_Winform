using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
    /// <summary>
    /// Generated Configuration for Table : ADConfigValues.
    /// </summary>
    public class ADConfigValuesConfiguration : IEntityTypeConfiguration<ADConfigValues>
    {
        public void Configure(EntityTypeBuilder<ADConfigValues> builder)
        {
            #region Generated Configuration By Column

            builder.ToTable("ADConfigValues");

            builder.HasKey(s => s.ADConfigValueID);

            builder.Property(x => x.ADConfigValueID).UseIdentityColumn();

            builder.Property(s => s.AAStatus).HasMaxLength(10);

            builder.Property(s => s.ADConfigKey).IsRequired().HasMaxLength(100);

            builder.Property(s => s.ADConfigKeyValue).IsRequired().HasMaxLength(100);

            builder.Property(s => s.ADConfigText).HasMaxLength(1000);

            builder.Property(s => s.ADConfigKeyDesc).HasMaxLength(500);

            builder.Property(s => s.ADConfigKeyGroup).IsRequired().HasMaxLength(50);

            #endregion
        }
    }
}