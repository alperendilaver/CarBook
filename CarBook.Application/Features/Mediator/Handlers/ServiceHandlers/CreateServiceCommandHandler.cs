﻿
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;

namespace CarBook.Application.Services.Mediator.Handlers.ServiceHandlers
{
	public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand>
	{
		private readonly IRepository<Service> _repository;

		public CreateServiceCommandHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Service { IconUrl = request.IconUrl,
			Title= request.Title,
			Description = request.Description});
		}
	}
}
