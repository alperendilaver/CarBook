using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CarBook.Application.Features.Mediator.Commands.FooterAdressCommands
{
	public class UpdateFooterAdressCommand : IRequest
	{
		public int FooterAdressId { get; set; }
		public string Descriptoin { get; set; }
		public string Adress { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}
}
