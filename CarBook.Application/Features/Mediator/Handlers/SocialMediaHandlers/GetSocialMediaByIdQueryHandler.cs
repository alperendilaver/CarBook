
using CarBook.Application.Services.Mediator.Results.ServiceResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;

namespace CarBook.Application.Services.Mediator.Handlers.SocialMediaHandlers
{
	public class GetTestimonialByIdQueryHandler: IRequestHandler<GetSocialMediaByIdQuery,GetSocialMediaByIdQueryResult>
	{
		private readonly IRepository<SocialMedia> _repository;

		public GetTestimonialByIdQueryHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.Id);
			return new GetSocialMediaByIdQueryResult {IconUrl = value.IconUrl,Url =  value.Url,SocialMediaId = value.SocialMediaId,Name=value.Name
		};
		}
	}
}
