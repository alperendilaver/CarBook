﻿using CarBook.Application.Features.Mediator.Commands.FeatureCommands;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
	public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateServiceCommand>
	{
		private readonly IRepository<Service> _repository;

		public UpdateSocialMediaCommandHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateServiceCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.ServiceId);
			value.Description = request.Description;
			value.Title = request.Title;
			value.IconUrl = request.IconUrl;

			await _repository.UpdateAsync(value);
		}
	}
}
