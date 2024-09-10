﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.BannerCommands
{
    public class DeleteBannerCommand:IRequest
    {
        public int BannerId { get; set; }
    }
}
