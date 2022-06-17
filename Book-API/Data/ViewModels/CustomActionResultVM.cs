using Book_API.Models;
using System;

namespace Book_API.Data.ViewModels
{
    public class CustomActionResultVM
    {
        public Exception Exception { get; set; }
        public Publisher Publisher { get; set; }
    }
}
