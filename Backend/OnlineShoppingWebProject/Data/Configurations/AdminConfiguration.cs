using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
	internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
	{
		public void Configure(EntityTypeBuilder<Admin> builder)
		{
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Id)
				.ValueGeneratedOnAdd();

			builder.HasIndex(x => x.Username)
				.IsUnique();
			builder.Property(x => x.Username)
				.IsRequired();

<<<<<<< HEAD
=======
			builder.HasIndex(x => x.Email)
				.IsUnique();
>>>>>>> a7aea91e0d5ffcffd71714a402ecc42b8df1b26f
			builder.Property(x => x.Email)
				.IsRequired();

			builder.Property(x => x.ProfileImage)
				.HasColumnType("varchar(100)");
		}
	}
}
