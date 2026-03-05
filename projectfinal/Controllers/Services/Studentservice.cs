using Microsoft.AspNetCore.Http.HttpResults;
using projectfinal.Controllers.dto;
using projectfinal.Controllers.models;
using Microsoft.EntityFrameworkCore;
using projectfinal.Controllers.Repository;


namespace projectfinal.Controllers.Services
{
	public class Studentservice(Irepository repo) : Iservice
	{
		public async Task<IEnumerable<Cricketer?>> getall()
		{
			return await repo.getcric();
		}
		public async Task<Cricketer?> getid(Guid jersey)
		{
		return await repo.getidd(jersey);

			}
		public async Task<Cricketer?> getdel(Guid jersey)
		{
			var aft= await repo.getidd(jersey);
			if (aft == null)
			{
				return null;
			}
			await repo.getdell(aft);
			await repo.save();
			return aft;
		}
		public  async Task<Cricketer?> getup(Added ad, Guid jersey)
		{
			var af = await repo.getidd(jersey);
			if (af == null)
			{
				return null;
			}

			af.name = ad.name;
			await repo.save();
			return af;
		}
		public async Task<Cricketer?> getadd(Update up)
		{
			var hari = new Cricketer
			{
				jersey = Guid.NewGuid(),
				name = up.name
			};
			await repo.Add(hari);
			await repo.save();
			return hari;
		}
	}
}
