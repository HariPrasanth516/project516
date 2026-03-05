using projectfinal.Controllers.dto;
using projectfinal.Controllers.models;

namespace projectfinal.Controllers.Services
{
	public interface Iservice
	{
		Task<IEnumerable<Cricketer?>> getall();
		Task<Cricketer?> getid(Guid jersey);

		Task<Cricketer?> getdel(Guid jersey);

		Task<Cricketer?> getup(Added ad, Guid jersey);

		Task<Cricketer?> getadd(Update up);
	}
}
