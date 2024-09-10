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

namespace CarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
	public class DeleteFooterAdressCommandHandler : IRequestHandler<DeleteFooterAdressCommand>
	{
		private readonly IRepository<FooterAdress> _repository;

		public DeleteFooterAdressCommandHandler(IRepository<FooterAdress> repository)
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
