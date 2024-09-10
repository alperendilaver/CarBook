
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Features.Mediator.Queries.PricingQueries;

namespace CarBook.Application.Pricings.Mediator.Handlers.PricingHandlers
{
	public class GetPricingByIdQueryHandler: IRequestHandler<GetPricingByIdQuery,GetPricingByIdQueryResult>
	{
		private readonly IRepository<Pricing> _repository;

		public GetPricingByIdQueryHandler(IRepository<Pricing> repository)
		{
			_repository = repository;
		}

		public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.Id);
			return new GetPricingByIdQueryResult { PricingId = value.PricingId,Name=value.Name };
		}
	}
}
