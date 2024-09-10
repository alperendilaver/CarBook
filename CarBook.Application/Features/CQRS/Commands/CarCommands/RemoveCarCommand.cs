using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarCommands
{
	public class RemoveCategoryCommand
	{
        public int CarId { get; set; }
    }
}
