using BookStore.Interface_Adapters.Data.Configurations.Template;
using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Interface_Adapters.Data.Configurations
{
	internal class EntityBookConfiguration : EntityConfiguration<Book>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Book> builder)
		{
			builder.HasIndex(book => book.Title).IsUnique();
			builder.HasMany(book => book.Genres).WithMany(genre => genre.Books);
			builder.HasMany(book => book.Writters).WithMany(writter => writter.Books);
			builder.HasMany(book => book.Images).WithOne(image => image.Book);
			builder.HasOne(book => book.Status).WithMany(status => status.Books).OnDelete(DeleteBehavior.NoAction);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Book> builder)
		{
			builder.Property(book => book.Title).HasMaxLength(150);
			builder.Property(book => book.PageCount).IsRequired(true);
			builder.Property(book => book.PublishedDate).IsRequired(true);
		}
	}
}
