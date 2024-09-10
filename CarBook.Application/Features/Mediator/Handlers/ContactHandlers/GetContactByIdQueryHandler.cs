
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.ContactQueries;
using CarBook.Application.Features.Mediator.Results.ContactResults;

namespace CarBook.Application.Contacts.Mediator.Handlers.ContactHandlers
{
	public class GetContactByIdQueryHandler: IRequestHandler<GetContactByIdQuery,GetContactByIdQueryResult>
	{
		private readonly IRepository<Contact> _repository;

		public GetContactByIdQueryHandler(IRepository<Contact> repository)
		{
			_repository = repository;
		}

		public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.Id);
			return new GetContactByIdQueryResult { Name = value.Name ,ContactId = value.ContactId,Subject=value.Subject,SendDate=value.SendDate,Message=value.Message,Email=value.Email};
		}
	}
}
