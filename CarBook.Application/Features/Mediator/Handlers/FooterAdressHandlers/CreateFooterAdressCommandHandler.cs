﻿using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
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
	public class CreateFooterAdressCommandHandler : IRequestHandler<CreateFooterAdressCommand>
	{
		private readonly IRepository<FooterAdress> _repository;

		public CreateFooterAdressCommandHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateFooterAdressCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new FooterAdress { Phone = request.Phone,
			Email = request.Email,
			Descriptoin = request.Descriptoin,
			Adress = request.Adress});
		}
	}
}
