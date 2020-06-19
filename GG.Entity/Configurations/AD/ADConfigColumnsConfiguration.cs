using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
    /// <summary>
    /// Generated Configuration for Table : ADConfigColumns.
    /// </summary>
    public class ADConfigColumnsConfiguration : IEntityTypeConfiguration<ADConfigColumns>
    {
        public void Configure(EntityTypeBuilder<ADConfigColumns> builder)
        {
            #region Generated Configuration By Column

            builder.ToTable("ADConfigColumns");

            builder.HasKey(x => x.ADConfigColumnID);

            //builder.Property(x => x.ADConfigColumnID).UseIdentityColumn();

            builder.Property(s => s.AAStatus).HasMaxLength(50);

            builder.Property(s => s.ADConfigColumnName).IsRequired().HasMaxLength(255);

            builder.Property(s => s.ADConfigColumnCaption).IsRequired().HasMaxLength(250);

            builder.Property(s => s.ADConfigColumnDataType).IsRequired().HasMaxLength(200);

            builder.Property(s => s.ADConfigColumnDisplayFormat).HasMaxLength(250);

            builder.Property(s => s.ADConfigColumnTableName).IsRequired().HasMaxLength(250);

            builder.Property(s => s.ADConfigColumnFunctionCode).HasMaxLength(500);

            builder.Property(s => s.ADConfigColumnDataSource).HasMaxLength(250);

            builder.Property(s => s.ADConfigColumnDisplayMember).HasMaxLength(500);

            builder.Property(s => s.ADConfigColumnValueMember).HasMaxLength(500);

            builder.Property(s => s.ADConfigColumnFilter).HasMaxLength(500);
            #endregion
        }
    }
}