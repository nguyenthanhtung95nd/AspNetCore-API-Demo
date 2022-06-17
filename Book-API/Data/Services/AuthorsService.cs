using Book_API.Data.Base;
using Book_API.Data.Services.Interfaces;
using Book_API.Data.ViewModels;
using Book_API.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Book_API.Data.Services
{
    public class AuthorsService : IAuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM book)
        {
            var _author = new Author()
            {
                FullName = book.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.BookAuthors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }
    }
}
