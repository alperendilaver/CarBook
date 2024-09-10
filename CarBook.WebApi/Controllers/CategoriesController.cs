using CarBook.Application.Features.CQRS.Commands.CategoryCommands;
using CarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly CreateCategoryCommandHandler _createCommandHandler;
		private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
		private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
		private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;
		private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;

		public CategoriesController(CreateCategoryCommandHandler createCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler, RemoveCategoryCommandHandler removeCategoryCommandHandler, UpdateCategoryCommandHandler updateCategoryCommandHandler)
		{
			_createCommandHandler = createCommandHandler;
			_getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
			_getCategoryQueryHandler = getCategoryQueryHandler;
			_removeCategoryCommandHandler = removeCategoryCommandHandler;
			_updateCategoryCommandHandler = updateCategoryCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{
			var values = await _getCategoryQueryHandler.Handle();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(int id)
		{
			var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
			return Ok(value);
		}
		//[HttpPost]
		//public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
		//{
		//	await _createCommandHandler.Handle(command);
		//	return Ok("Kategori Eklendi");
		//}
		//[HttpDelete]
		//public async Task<IActionResult> RemoveBrand(RemoveCategoryCommand command)
		//{
		//	await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommand(command.CategoryId));
		//	return Ok("Marka Silindi");
		//}
		//[HttpPut]
		//public async Task<IActionResult> Update(UpdateCategoryCommand command)
		//{
		//	await _updateCategoryCommandHandler.Handle(command);
		//	return Ok("Marka Güncellendi");
		//}
	}
}
