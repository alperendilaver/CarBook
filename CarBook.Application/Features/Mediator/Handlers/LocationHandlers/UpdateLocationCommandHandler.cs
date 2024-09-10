﻿using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;

namespace CarBook.Application.Locations.Mediator.Handlers.LocationHandlers
{
	public class UpdateContactCommandHandler : IRequestHandler<UpdateLocationCommand>
	{
		private readonly IRepository<Location> _repository;

		public UpdateContactCommandHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.LocationId);
			value.Name = request.Name;
			await _repository.UpdateAsync(value);
		}
	}
}
