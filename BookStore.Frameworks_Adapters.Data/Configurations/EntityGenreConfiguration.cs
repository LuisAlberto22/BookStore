using BookStore.Interface_Adapters.Data.Configurations.Template;
using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Interface_Adapters.Data.Configurations
{
	internal class EntityGenreConfiguration : EntityConfiguration<Genre>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Genre> builder)
		{
			builder.HasIndex(genre => genre.Name).IsUnique();
			builder.HasOne(genre => genre.Status).WithMany(status => status.Genres).OnDelete(DeleteBehavior.NoAction);

		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Genre> builder)
		{
			builder.Property(genre => genre.Name).IsRequired().HasMaxLength(150);
		}
	}
}
