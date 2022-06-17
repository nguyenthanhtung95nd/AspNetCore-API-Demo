using Book_API.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class BookAuthor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
