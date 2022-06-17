using Book_API.Data.Services.Interfaces;
using Book_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Book_API.Data.Services
{
    public class LogsService : ILogsService
    {
        private readonly AppDbContext _context;
        public LogsService(AppDbContext context)
        {
            _context = context;
        }

        public List<Log> GetAllLogsFromDB() => _context.Logs.ToList();
    }
}
