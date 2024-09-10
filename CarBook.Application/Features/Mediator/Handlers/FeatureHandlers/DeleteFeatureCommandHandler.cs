using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.FooterAdressCommands;
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
	public class DeleteFooterAdressCommandHandler : IRequestHandler<DeleteFooterAdressCommand>
	{
		private readonly IRepository<Feature> _repository;

		public DeleteFooterAdressCommandHandler(IRepository<Feature> repository)
		{
			_repository = repository;
		}

		public async Task Handle(DeleteFooterAdressCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.FooterAdressId);
			await _repository.RemoveAsync(value);
		}
	}
}
