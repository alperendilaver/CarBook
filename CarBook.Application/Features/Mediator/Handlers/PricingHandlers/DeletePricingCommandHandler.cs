
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.PricingCommands;

namespace CarBook.Application.Pricings.Mediator.Handlers.PricingHandlers
{
	public class DeletePricingCommandHandler : IRequestHandler<DeletePricingCommand>
	{
		private readonly IRepository<Pricing> _repository;

		public DeletePricingCommandHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(DeletePricingCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.PricingId);
			await _repository.RemoveAsync(value);
		}
	}
}
