using CarBook.Application.Interfaces.BlogRepositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _carBookContext;

        public BlogRepository(CarBookContext carBookContext)
        {
            _carBookContext = carBookContext;
        }

        public async Task<Blog> GetBlogForDetailByIdAsync(int id)
        {
            return await _carBookContext.Blogs.Where(x => x.BlogId == id).Include(x => x.Author).FirstOrDefaultAsync();
        }

        public async Task<List<Blog>> GetBlogsWithAuthors()
        {
            return await _carBookContext.Blogs.Include(x => x.Author).ToListAsync();
        }

        public async Task<List<Blog>> GetLast3BlogsWithAuthor()
        {
            return await _carBookContext.Blogs.OrderByDescending(x=>x.BlogId).Include(x => x.Author).Take(3).ToListAsync();
        }
    }
}
