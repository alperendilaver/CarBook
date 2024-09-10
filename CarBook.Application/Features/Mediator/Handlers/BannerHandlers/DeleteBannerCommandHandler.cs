using CarBook.Application.Features.Mediator.Commands.BannerCommands;
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
    public class DeleteBannerCommandHandler : IRequestHandler<DeleteBannerCommand>
    {
        private readonly IRepository<Banner> _repository;

        public DeleteBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public  async Task Handle(DeleteBannerCommand request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetByIdAsync(request.BannerId);
            await _repository.RemoveAsync(values);
        }
    }
}
