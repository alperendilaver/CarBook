using CarBook.Application.Features.Mediator.Commands.BlogCommands;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
      

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetLast3BlogsWithAuthor")]
        public async Task<IActionResult> GetLast3Blog()
        {
            var values =await _mediator.Send(new GetLast3BlogsWithAuthorQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogsWithAuthor")]
        public async Task<IActionResult> GetBlogsWithAuthor()
        {
            var values = await _mediator.Send(new GetBlogsWithAuthorQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogDetail/{id}")]
        public async Task<IActionResult> GetBlogDetail(int id)
        {
            var value = await _mediator.Send(new GetBlogDetailQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Başarılı");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(DeleteBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Silindi");
        }
      
       
    }
}
