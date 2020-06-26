using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : ConfigColumns.
	/// </summary>
	public class ConfigColumnsConfiguration : IEntityTypeConfiguration<ConfigColumns>
	{
		public void Configure (EntityTypeBuilder<ConfigColumns> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("ConfigColumns");

			builder.HasKey(s => s.ConfigColumnID);

			builder.Property(x => x.ConfigColumnID).UseIdentityColumn();

			builder.Property(s => s.Status).HasMaxLength(50);

			builder.Property(s => s.ConfigColumnName).IsRequired().HasMaxLength(255);

			builder.Property(s => s.ConfigColumnCaption).IsRequired().HasMaxLength(250);

			builder.Property(s => s.ConfigColumnDataType).IsRequired().HasMaxLength(200);

			builder.Property(s => s.ConfigColumnDisplayFormat).HasMaxLength(250);

			builder.Property(s => s.ConfigColumnTableName).IsRequired().HasMaxLength(250);

			builder.Property(s => s.ConfigColumnFunctionCode).HasMaxLength(500);

			builder.Property(s => s.ConfigColumnDataSource).HasMaxLength(250);

			builder.Property(s => s.ConfigColumnDisplayMember).HasMaxLength(500);

			builder.Property(s => s.ConfigColumnValueMember).HasMaxLength(500);

			builder.Property(s => s.ConfigColumnFilter).HasMaxLength(500);

			#endregion
		}
	}
}