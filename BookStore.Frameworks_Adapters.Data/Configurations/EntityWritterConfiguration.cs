using BookStore.Interface_Adapters.Data.Configurations.Template;
using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Interface_Adapters.Data.Configurations
{
	internal class EntityWritterConfiguration : EntityConfiguration<Writter>
	{
		protected override void ConfigurateConstrains(EntityTypeBuilder<Writter> builder)
		{
			builder.HasIndex(writter => writter.Name);
			builder.HasOne(writter => writter.Status).WithMany(status => status.Writters).OnDelete(DeleteBehavior.NoAction);
			builder.HasMany(writter => writter.Books).WithMany(book => book.Writters);
		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Writter> builder)
		{
			builder.Property(writter => writter.Name).IsRequired().HasMaxLength(150);
			builder.Property(writter => writter.Biography).IsRequired(false).HasColumnType("TEXT");
			builder.Property(writter => writter.BirthDate).IsRequired();
			builder.Property(writter => writter.Photo).IsRequired(false).IsUnicode();
		}
	}
}
