using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Commands.ContactCommands;

namespace CarBook.Application.Contacts.Mediator.Handlers.ContactHandlers
{
	public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand>
	{
		private readonly IRepository<Contact> _repository;

		public UpdateContactCommandHandler(IRepository<Contact> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.ContactId);
			value.Name = request.Name;
			value.Email = request.Email;
			value.SendDate = request.SendDate;
			value.Subject = request.Subject;
			value.Message = request.Message;
			await _repository.UpdateAsync(value);
		}
	}
}
