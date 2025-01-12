using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookStore.Interface_Adapters.Data
{
	public class AppDBContext : DbContext
	{
		public AppDBContext(DbContextOptions options) : base(options) 
		{
		
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}
	}
}
