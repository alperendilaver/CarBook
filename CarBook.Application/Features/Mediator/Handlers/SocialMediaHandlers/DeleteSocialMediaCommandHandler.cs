
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.ServiceCommands;
using CarBook.Application.Features.Mediator.Commands.SocialMediaCommands;

namespace CarBook.Application.Services.Mediator.Handlers.SocialMediaHandlers
{
	public class DeleteTestimonialCommandHandler : IRequestHandler<DeleteSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public DeleteTestimonialCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.SocialMediaId);
			await _repository.RemoveAsync(value);
		}
	}
}
