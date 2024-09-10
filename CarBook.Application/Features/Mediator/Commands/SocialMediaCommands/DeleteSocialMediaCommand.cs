using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
	public class DeleteSocialMediaCommand:IRequest
	{
		public int SocialMediaId { get; set; }
		
	}
}
