using Azure;
using BookStore.Interface_Adapters.Data.Configurations.Template;
using BookStore.Interface_Adapters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Interface_Adapters.Data.Configurations
{
	internal class EntityStatusConfiguration : EntityConfiguration<Status>
	{

		protected override void ConfigurateTable(EntityTypeBuilder<Status> builder)
		{
			builder.ToTable("Statuses");
		}

		protected override void ConfigurateConstrains(EntityTypeBuilder<Status> builder)
		{
			builder.HasIndex(status => status.Name).IsUnique();

		}

		protected override void ConfigurateProperties(EntityTypeBuilder<Status> builder)
		{
			builder.Property(status => status.Name).IsRequired().HasMaxLength(50);
		}
	}
}
