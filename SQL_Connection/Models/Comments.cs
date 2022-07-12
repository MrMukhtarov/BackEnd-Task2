using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Connection.Models
{

    public class Comments
    {

        public int Id { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
