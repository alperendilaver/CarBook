using CarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using CarBook.Application.Features.Mediator.Results.FooterAdressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.FooterAdresss.Mediator.Handlers.FooterAdressHandlers
{
	public class GetFooterAdressByIdQueryHandler: IRequestHandler<GetFooterAdressByIdQuery,GetContactByIdQueryResult>
	{
		private readonly IRepository<FooterAdress> _repository;

		public GetFooterAdressByIdQueryHandler(IRepository<FooterAdress> repository)
		{
			_repository = repository;
		}

		public async Task<GetContactByIdQueryResult> Handle(GetFooterAdressByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.Id);
			return new GetContactByIdQueryResult {Adress = value.Adress,
			Descriptoin=value.Descriptoin,
			Email = value.Email,
			FooterAdressId = value.FooterAdressId,
			Phone = value.Phone};
		}
	}
}
