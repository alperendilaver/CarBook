
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Results.LocationResults;

namespace CarBook.Application.Locations.Mediator.Handlers.LocationHandlers
{
	public class GetContactByIdQueryHandler: IRequestHandler<GetLocationByIdQuery,GetLocationByIdQueryResult>
	{
		private readonly IRepository<Location> _repository;

		public GetContactByIdQueryHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.Id);
			return new GetLocationByIdQueryResult { Name = value.Name ,LocationId = value.LocationId};
		}
	}
}
