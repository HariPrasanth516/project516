using Microsoft.EntityFrameworkCore;
using projectfinal.Controllers.models;

namespace projectfinal.Controllers.data
{
	//hello world hari
	public class Applicationdbcontext : DbContext
	{
		public Applicationdbcontext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Cricketer> cricket { get; set; }
	}
}
