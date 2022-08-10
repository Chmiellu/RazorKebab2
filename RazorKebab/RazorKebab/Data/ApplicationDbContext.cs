using Microsoft.EntityFrameworkCore;
using RazorKebab.Models;


namespace RazorKebab.Data
{
	public class ApplicationDbContext:DbContext
	{
		public DbSet<KebabOrder> KebabOrders { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			 
		}
	}
}
