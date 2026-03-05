using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectfinal.Controllers.models
{
	public class Cricketer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public Guid jersey {  get; set; }
		public string? name {  get; set; }
	}
}
