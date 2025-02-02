﻿using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.ContactCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.ContactHandlers
{
	public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand>
	{
		private readonly IRepository<Contact> _repository;

		public DeleteContactCommandHandler(IRepository<Contact> repository)
		{
			_repository = repository;
		}

		public async Task Handle(DeleteContactCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.ContactId);
			await _repository.RemoveAsync(value);
		}
	}
}
