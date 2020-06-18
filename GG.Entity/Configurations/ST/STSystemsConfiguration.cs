using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : STSystems.
	/// </summary>
	public class STSystemsConfiguration : IEntityTypeConfiguration<STSystems>
	{
		public void Configure(EntityTypeBuilder<STSystems> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("STSystems");

			builder.HasKey(s => s.STSystemID);

			builder.Property(x => x.STSystemID).UseIdentityColumn();

			builder.Property(s => s.AAStatus).HasMaxLength(10);

			builder.Property(s => s.STSystemNo).IsRequired().HasMaxLength(100);

			builder.Property(s => s.STSystemName).HasMaxLength(500);

			#endregion
		}
	}
}