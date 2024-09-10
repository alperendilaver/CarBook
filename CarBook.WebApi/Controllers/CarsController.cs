using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.CarResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{

		private readonly CreateCarCommandHandler _createCarCommandHandler;
		private readonly UpdateCarCommandHandler _updateCarCommandHandler;
		private readonly RemoveCarCommandHandler _removeCarCommandHandler;
		private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
		private readonly GetCarQueryHandler _getCarQueryHandler;
		private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
		private readonly GetLast5CarWithBrandHandler _getLast5CarWithBrandHandler;
		private readonly GetCarsWithPricingQueryHandler _getCarsWithPricingQueryHandler;
		public CarsController(GetCarsWithPricingQueryHandler getCarsWithPricingQueryResult,CreateCarCommandHandler createCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, GetCarQueryHandler getCarQueryHandler,GetCarWithBrandQueryHandler getCarWithBrandQueryHandler, GetLast5CarWithBrandHandler getLast5CarWithBrandHandler)
		{
			_getCarsWithPricingQueryHandler = getCarsWithPricingQueryResult;
			_createCarCommandHandler = createCarCommandHandler;
			_updateCarCommandHandler = updateCarCommandHandler;
			_removeCarCommandHandler = removeCarCommandHandler;
			_getCarByIdQueryHandler = getCarByIdQueryHandler;
			_getCarQueryHandler = getCarQueryHandler;
			_getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
			_getLast5CarWithBrandHandler = getLast5CarWithBrandHandler;
		}

		// GET: api/<ValuesController>
		[HttpGet]
		public async Task<IActionResult> CarList()
		{
			var values =await _getCarQueryHandler.Handle();
			return Ok(values);
		}

		// GET api/<ValuesController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCar(int id)
		{
			var value =await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
			return Ok(value);
		}

		// POST api/<ValuesController>
		[HttpPost]
		public async Task<IActionResult> CreateCar(CreateCategoryCommand command)
		{
			await _createCarCommandHandler.Handle(command);
			return Ok("Araba Eklendi");
		}

		// PUT api/<ValuesController>/5
		[HttpPut]
		public async Task<IActionResult> UpdateCar(UpdateCategoryCommand command)
		{
			await _updateCarCommandHandler.Handle(command);
			return Ok("Güncellendi");
		}

		// DELETE api/<ValuesController>/5
		[HttpDelete]
		public async Task<IActionResult> DeleteCar(RemoveCategoryCommand command)
		{
			await _removeCarCommandHandler.Handle(command);
			return Ok("Silindi");
		}

		[HttpGet("GetCarWithBrand")]
		public async Task<IActionResult> GetCarWithBrand()
		{
			var values =await _getCarWithBrandQueryHandler.Handle();
			return Ok(values);
		}

		[HttpGet("GetLast5CarWithBrand")]
		public async Task<IActionResult> GetLast5CarWithBrand()
		{
			var values = await _getLast5CarWithBrandHandler.Handle();
			return Ok(values);
		}
		[HttpGet("GetCarsWithPricing")]
		public async Task<IActionResult> GetCarsWithPricing()
		{
			var values = await _getCarsWithPricingQueryHandler.Handle();
			return Ok(values);
		}
	}
}
