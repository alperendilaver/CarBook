﻿using CarBook.Application.Features.Mediator.Commands.BannerCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommand>
    {
        private readonly IRepository<Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.BannerId);
            value.VideoDescription = request.VideoDescription;
            value.Title = request.Title;
            value.VideoUrl = request.VideoUrl;  
            value.Description = request.Description;
            await _repository.UpdateAsync(value);   
        }
    }
}
