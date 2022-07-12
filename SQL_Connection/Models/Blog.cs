using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public DateTime RealaseDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Comments> Comments { get; set; }

        public Blog()
        {
            Comments = new List<Comments>();
        }
    }
}
