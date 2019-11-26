using System.Collections.Generic;
using Knigosha.Core.Models;

namespace Knigosha.Core.ViewModels
{
    public class HomeViewModel
    {
        public List<Book> LatestAddedBooks { get; set; }
        public List<Book> MostPopularBooks { get; set; }
        public List<Text> RecentNews { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public List<int> BooksIds { get; set; }
    }
}