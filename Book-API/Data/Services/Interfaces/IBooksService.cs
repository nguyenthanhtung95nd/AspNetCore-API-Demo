using Book_API.Data.ViewModels;
using Book_API.Models;
using System.Collections.Generic;

namespace Book_API.Data.Services.Interfaces
{
    public interface IBooksService
    {
        void AddBookWithAuthors(BookVM book);
        List<Book> GetAllBooks();
        BookWithAuthorsVM GetBookById(int bookId);
        Book UpdateBookById(int bookId, BookVM book);
        void DeleteBookById(int bookId);
    }
}
