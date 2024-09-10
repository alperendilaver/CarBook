using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorQuery, List<GetLast3BlogsWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetLast3BlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetLast3BlogsWithAuthorQueryResult>> Handle(GetLast3BlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var entities = await _blogRepository.GetLast3BlogsWithAuthor();
            return entities.Select(x=>new GetLast3BlogsWithAuthorQueryResult { AuthorName = x.Author.Name,BlogId = x.BlogId,CategoryId=x.CategoryId,CoverImageUrl = x.CoverImageUrl,CreatedTime = x.CreatedTime,Title=x.Title}).ToList();
        }
    }
}
