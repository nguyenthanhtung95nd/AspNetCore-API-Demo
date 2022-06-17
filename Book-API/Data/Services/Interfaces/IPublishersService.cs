using Book_API.Data.ViewModels;
using Book_API.Models;
using System.Collections.Generic;

namespace Book_API.Data.Services.Interfaces
{
    public interface IPublishersService
    {
        List<Publisher> GetAllPublishers(string sortBy, string searchString, int? pageNumber);
        public Publisher AddPublisher(PublisherVM publisher);
        public Publisher GetPublisherById(int id);
        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId);
        public void DeletePublisherById(int id);
    }
}
