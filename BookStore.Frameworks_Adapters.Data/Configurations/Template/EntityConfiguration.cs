using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Interface_Adapters.Data.Configurations.Template
{
	internal abstract class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Model
	{
		public void Configure(EntityTypeBuilder<T> builder)
		{
			ConfigurateConstrains(builder);
			ConfigurateProperties(builder);
			ConfigurateTable(builder);
		}

		protected virtual void ConfigurateTable(EntityTypeBuilder<T> builder)
		{

			builder.ToTable(typeof(T).Name + "s");
		}

		protected abstract void ConfigurateConstrains(EntityTypeBuilder<T> builder);
		protected abstract void ConfigurateProperties(EntityTypeBuilder<T> builder);
	}
}
