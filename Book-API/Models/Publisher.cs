using Book_API.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class Publisher : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation Properties
        public List<Book> Books { get; set; }
    }
}
