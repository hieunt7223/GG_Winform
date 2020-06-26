using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GG.Entity
{
	/// <summary>
	/// Generated Configuration for Table : FieldColumns.
	/// </summary>
	public class FieldColumnsConfiguration : IEntityTypeConfiguration<FieldColumns>
	{
		public void Configure (EntityTypeBuilder<FieldColumns> builder)
		{
			#region Generated Configuration By Column

			builder.ToTable("FieldColumns");

			builder.HasKey(s => s.FieldColumnID);

			builder.Property(x => x.FieldColumnID).UseIdentityColumn();

			builder.Property(s => s.Status).HasMaxLength(50);

			builder.Property(s => s.FieldColumnFormName).HasMaxLength(500);

			#endregion
		}
	}
}