
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
	public class CreateTestimonialCommandHandler : IRequestHandler<CreateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public CreateTestimonialCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new SocialMedia { IconUrl = request.IconUrl,
			Name  = request.Name,
			Url = request.Url});
		}
	}
}
