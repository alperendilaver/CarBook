using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommands
{
	public class UpdateSocialMediaCommand:IRequest
	{
		public int SocialMediaId { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public string IconUrl { get; set; }
	}
}
