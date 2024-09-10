
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

namespace CarBook.Application.Services.Mediator.Handlers.SocialMediaHandlers
{
	public class GetTestimonialQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
	{
		private readonly IRepository<Service> _repository;

		public GetTestimonialQueryHandler(IRepository<Service> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetServiceQueryResult { IconUrl = x.IconUrl,Title=x.Title,Description = x.Description, ServiceId = x.ServiceId }).ToList();
		}
	}
}
