using Book_API.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Book_API.Models
{
    public class Log : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageTemplate { get; set; }
        public string Level { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Exception { get; set; }
        public string Properties { get; set; } //XML properties
        public string LogEvent { get; set; }
    }
}
