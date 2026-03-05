using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using projectfinal.Controllers.dto;
using projectfinal.Controllers.models;
using projectfinal.Controllers.Services;
using Microsoft.EntityFrameworkCore;

namespace projectfinal.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly Iservice studentservice;

		public ValuesController(Iservice Studentservice)
		{
			studentservice = Studentservice;
		}
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var res = await studentservice.getall();
			return Ok(res);
		}
		[HttpGet]
		[Route("{jersey:guid}")]
		public async Task<IActionResult> getbyid(Guid jersey)
		{
			var resu = await studentservice.getid(jersey);
			return Ok(resu);	
		}
		[HttpDelete]
		[Route("{jersey:guid}")]
		public async Task<IActionResult> del(Guid jersey)
		{
			var resul =await studentservice.getdel(jersey);
			return Ok(resul);
		}
		[HttpPut]
		[Route("{jersey:guid}")]
		public async Task<IActionResult> updat([FromBody] Added ad,Guid jersey)
		{
			var result = await studentservice.getup(ad, jersey);
			return Ok();
		}
		[HttpPost]
		public async Task<IActionResult> adde([FromBody] Update up)
		{
			var result = await studentservice.getadd(up);
			return Ok(result);
		}
	}
}
