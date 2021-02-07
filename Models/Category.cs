using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dagens.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<ArticleCategory> CategoryArticles { get; set; }

    }
}
