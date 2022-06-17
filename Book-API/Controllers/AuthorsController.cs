using Book_API.Data.Services.Interfaces;
using Book_API.Data.Static;
using Book_API.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Book_API.Controllers
{
    [Authorize(Roles = UserRoles.Author)]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsService _authorsService;

        public AuthorsController(IAuthorsService authorsService)
        {
            _authorsService = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorsService.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var response = _authorsService.GetAuthorWithBooks(id);
            return Ok(response);
        }
    }
}
