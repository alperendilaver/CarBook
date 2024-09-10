using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using CarBook.Application.Interfaces.BlogRepositories;
using MediatR;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
   public class GetBlogsWithAuthorQueryHandler : IRequestHandler<GetBlogsWithAuthorQuery, List<GetBlogsWithAuthorResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogsWithAuthorResult>> Handle(GetBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetBlogsWithAuthors();
            return values.Select(x => new GetBlogsWithAuthorResult
            {
                BlogID = x.BlogId,
                Title = x.Title,
                AuthorName = x.Author.Name,
                CreatedDate = x.CreatedTime,
                CoverImageUrl = x.CoverImageUrl,
                AuthorID = x.AuthorId,
            }).ToList();
        }
    }
    
}