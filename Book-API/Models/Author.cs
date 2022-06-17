using Book_API.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class Author : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigations Properties
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
