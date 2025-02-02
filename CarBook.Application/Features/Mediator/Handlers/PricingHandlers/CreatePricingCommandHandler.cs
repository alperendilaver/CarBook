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

namespace CarBook.Application.Pricings.Mediator.Handlers.PricingHandlers
{
	public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommand>
	{
		private readonly IRepository<Pricing> _repository;

		public CreatePricingCommandHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Pricing {Name = request.Name});
		}
	}
}
