
using CarBook.Application.Services.Mediator.Results.ServiceResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Features.Mediator.Results.TestimonialResults;
using CarBook.Application.Features.Mediator.Queries.TestimonialQueries;

namespace CarBook.Application.Services.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialByIdQueryHandler: IRequestHandler<GetTestimonialByIdQuery,GetTestimonialByIdQueryResult>
	{
		private readonly IRepository<Testimonial> _repository;

		public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
		{
			_repository = repository;
		}

		public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
		{
			var value =await _repository.GetByIdAsync(request.TestimonialId);
			return new GetTestimonialByIdQueryResult { 
				TestimonialId = value.TestimonialId,Comment = value.Comment,Title = value.Title,Name = value.Name,ImageUrl = value.ImageUrl
		};
		}
	}
}
