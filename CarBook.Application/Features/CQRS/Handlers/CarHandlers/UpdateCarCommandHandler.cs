using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
	public class UpdateCarCommandHandler
	{
		private readonly IRepository<Car> _repository;

		public UpdateCarCommandHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCategoryCommand command)
		{
			var entity = await _repository.GetByIdAsync(command.CarId);
			entity.Transmission = command.Transmission;
			entity.BigImageUrl = command.BigImageUrl;
			entity.BrandId = command.BrandId;
			entity.CoverImageUrl = command.CoverImageUrl;
			entity.Fuel = command.Fuel;
			entity.Km = command.Km;
			entity.Seats = command.Seats;
			entity.Model = command.Model;
			entity.Luggage = command.Luggage;
			await _repository.UpdateAsync(entity);
		}
	}
}
