using Book_API.Models;
using System.Collections.Generic;

namespace Book_API.Data.Services.Interfaces
{
    public interface ILogsService
    {
        List<Log> GetAllLogsFromDB();
    }
}
