﻿using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery: IRequest<GetAuthorByIdQueryResult>
    {
        public int AuthorId { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            AuthorId = id;
        }
    }
}
