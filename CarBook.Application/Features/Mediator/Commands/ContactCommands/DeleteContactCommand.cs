using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.ContactCommands
{
	public class DeleteContactCommand:IRequest
	{
        public int ContactId { get; set; }
    

    }
}
