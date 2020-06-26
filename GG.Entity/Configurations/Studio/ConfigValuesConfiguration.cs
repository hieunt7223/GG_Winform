using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : ConfigValues.
	/// </summary>
	public class ConfigValuesConfiguration : IEntityTypeConfiguration<ConfigValues>
	{
		public void Configure (EntityTypeBuilder<ConfigValues> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("ConfigValues");

			builder.HasKey(s => s.ConfigValueID);

			builder.Property(x => x.ConfigValueID).UseIdentityColumn();

			builder.Property(s => s.Status).HasMaxLength(10);

			builder.Property(s => s.ConfigKey).IsRequired().HasMaxLength(100);

			builder.Property(s => s.ConfigKeyValue).IsRequired().HasMaxLength(100);

			builder.Property(s => s.ConfigText).HasMaxLength(1000);

			builder.Property(s => s.ConfigKeyDesc).HasMaxLength(500);

			builder.Property(s => s.ConfigKeyGroup).IsRequired().HasMaxLength(50);

			#endregion
		}
	}
}