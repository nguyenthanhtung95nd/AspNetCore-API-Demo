using Book_API.Data.ViewModels;

namespace Book_API.Data.Services.Interfaces
{
    public interface IAuthorsService
    {
        void AddAuthor(AuthorVM book);
        AuthorWithBooksVM GetAuthorWithBooks(int authorId);
    }
}
