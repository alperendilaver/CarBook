using CarBook.Application.Features.CQRS.Commands.AboutCommands;
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
	public class CreateCarCommandHandler
	{
		private readonly IRepository<Car> _repository;

		public CreateCarCommandHandler(IRepository<Car> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateCategoryCommand command) {
			await _repository.CreateAsync(new Car { BigImageUrl = command.BigImageUrl
			,CoverImageUrl = command.CoverImageUrl
			,BrandId = command.BrandId
			,Fuel = command.Fuel
			,Km = command.Km
			,Transmission = command.Transmission
			,Luggage = command.Luggage
			,Seats = command.Seats
			,Model = command.Model
			});
		}
	}
}
