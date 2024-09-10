using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.BlogRepositories
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetLast3BlogsWithAuthor();
        public Task<List<Blog>> GetBlogsWithAuthors();

        public Task<Blog> GetBlogForDetailByIdAsync(int id);
    }
}
