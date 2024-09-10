using CarBook.Application.Features.Mediator.Commands.ContactCommands;
using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.LocationCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
	public class DeleteContactCommandHandler : IRequestHandler<DeleteLocationCommand>
	{
		private readonly IRepository<Location> _repository;

		public DeleteContactCommandHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.LocationId);
			await _repository.RemoveAsync(value);
		}
	}
}
