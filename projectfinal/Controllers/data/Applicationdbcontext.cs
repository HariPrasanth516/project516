using Microsoft.EntityFrameworkCore;
using projectfinal.Controllers.models;

namespace projectfinal.Controllers.data
{
	//hello world
	public class Applicationdbcontext : DbContext
	{
		public Applicationdbcontext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Cricketer> cricket { get; set; }
	}
}
