using BookStore.Interface_Adapters.Data.Configurations.Template;
using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Interface_Adapters.Data.Configurations
{
	internal class EntityEditorConfiguration : EntityConfiguration<Editor>
	{

		protected override void ConfigurateConstrains(EntityTypeBuilder<Editor> builder)
		{
			builder.HasIndex(editor => editor.Name);
			builder.HasIndex(editor => editor.Code).IsUnique();
			builder.HasMany(editor => editor.Books).WithOne(book => book.Editor);
			builder.HasOne(editor => editor.Status).WithMany(status => status.Editors).OnDelete(DeleteBehavior.NoAction);

		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Editor> builder)
		{
			builder.Property(entity => entity.Name).IsRequired().HasMaxLength(150);
			builder.Property(entity => entity.Code).IsRequired();

		}
	}
}

