using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogsWithAuthorResult
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImageUrl { get; set; }
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
    }
}