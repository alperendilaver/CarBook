using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarBook.Application.Features.Mediator.Results.BlogResults;
using MediatR;

namespace CarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogDetailQuery : IRequest<GetBlogDetailQueryResult>
    {
        public GetBlogDetailQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}