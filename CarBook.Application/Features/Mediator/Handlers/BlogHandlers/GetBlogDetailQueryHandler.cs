using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.BlogRepositories;
using CarBook.Domain.Entities;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogDetailQueryHandler : IRequestHandler<GetBlogDetailQuery, GetBlogDetailQueryResult>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogDetailQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<GetBlogDetailQueryResult> Handle(GetBlogDetailQuery request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetBlogForDetailByIdAsync(request.Id);
            return new GetBlogDetailQueryResult
            {
                    BlogID = blogs.BlogId,
                    Title = blogs.Title,
                    CreatedDate = blogs.CreatedTime,
                    CoverImageUrl = blogs.CoverImageUrl,
                    AuthorID = blogs.AuthorId,
                    AuthorName = blogs.Author.Name
            };
        }
    }
}