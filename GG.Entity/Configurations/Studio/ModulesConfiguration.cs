using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : Modules.
	/// </summary>
	public class ModulesConfiguration : IEntityTypeConfiguration<Modules>
	{
		public void Configure (EntityTypeBuilder<Modules> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("Modules");

			builder.HasKey(s => s.ModuleID);

			builder.Property(x => x.ModuleID).UseIdentityColumn();

			builder.Property(s => s.Status).HasMaxLength(10);

			builder.Property(s => s.ModuleNo).IsRequired().HasMaxLength(100);

			builder.Property(s => s.ModuleName).HasMaxLength(500);

			builder.Property(s => s.ModuleType).HasMaxLength(100);

			builder.Property(s => s.ModuleCode).HasMaxLength(500);

			builder.Property(s => s.ModuleLink).HasMaxLength(500);

			#endregion
		}
	}
}