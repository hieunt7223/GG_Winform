using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : Systems.
	/// </summary>
	public class SystemsConfiguration : IEntityTypeConfiguration<Systems>
	{
		public void Configure (EntityTypeBuilder<Systems> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("Systems");

			builder.HasKey(s => s.SystemID);

			builder.Property(x => x.SystemID).UseIdentityColumn();

			builder.Property(s => s.Status).HasMaxLength(10);

			builder.Property(s => s.SystemNo).IsRequired().HasMaxLength(100);

			builder.Property(s => s.SystemName).HasMaxLength(500);

			#endregion
		}
	}
}