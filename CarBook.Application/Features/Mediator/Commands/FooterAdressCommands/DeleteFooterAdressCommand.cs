﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAdressCommands
{
	public class DeleteFooterAdressCommand : IRequest
	{
		public int FooterAdressId { get; set; }
	}
}
