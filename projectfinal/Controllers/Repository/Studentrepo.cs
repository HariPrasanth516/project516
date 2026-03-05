using projectfinal.Controllers.data;
using projectfinal.Controllers.models;
using Microsoft.EntityFrameworkCore;

namespace projectfinal.Controllers.Repository
{
	public class Studentrepo(Applicationdbcontext dbContext):Irepository
	{
		public async Task <IEnumerable<Cricketer>> getcric()
		{
			return await dbContext.cricket.ToListAsync();
		    
		}
		public async Task<Cricketer?> getidd(Guid jersey)
		{
			return await dbContext.cricket.FindAsync(jersey);
		}
		public async Task getdell(Cricketer aft)
		{
			dbContext.cricket.Remove(aft);
		}
		public async Task save()
		{
			dbContext.SaveChangesAsync();
		}
		public async Task Add(Cricketer ob)
		{
			
		 dbContext.cricket.AddAsync(ob);
		}
	}
}
