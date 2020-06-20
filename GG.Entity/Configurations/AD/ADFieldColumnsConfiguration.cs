using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : ADFieldColumns.
	/// </summary>
	public class ADFieldColumnsConfiguration : IEntityTypeConfiguration<ADFieldColumns>
	{
		public void Configure(EntityTypeBuilder<ADFieldColumns> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("ADFieldColumns");

			builder.HasKey(s => s.ADFieldColumnID);

			builder.Property(x => x.ADFieldColumnID).UseIdentityColumn();

			builder.Property(s => s.AAStatus).HasMaxLength(50);

			builder.Property(s => s.ADFieldColumnFormName).HasMaxLength(500);

			#endregion
		}
	}
}