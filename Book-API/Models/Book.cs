﻿using Book_API.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class Book : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Navigation Properties
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
