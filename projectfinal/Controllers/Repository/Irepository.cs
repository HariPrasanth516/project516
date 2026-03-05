using projectfinal.Controllers.dto;
using projectfinal.Controllers.models;

namespace projectfinal.Controllers.Repository
{
	public interface Irepository
	{
		public Task<IEnumerable<Cricketer>> getcric();
		Task<Cricketer?> getidd(Guid jersey);

		Task getdell(Cricketer aft);

		Task save();

		Task Add(Cricketer ob);
	}
}
