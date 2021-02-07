using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagens.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Ingredients { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Knockouts { get; set; }
        public string Wins { get; set; }
        public string Losses { get; set; }
        public string TotalMatches { get; set; }
        public string FromCountry { get; set; }
        public List<ArticleCategory> ArticleCategories { get; set; }
    }
}
