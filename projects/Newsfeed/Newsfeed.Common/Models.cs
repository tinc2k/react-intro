using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsfeed.Common.Models
{
    public class Author
    {
        public string SessionId { get; set; }
        public string Name { get; set; }
    }

    public class Status
    {
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public Author Author { get; set; }

        //public bool Public { get; set; }
        //public string Location { get; set; }
        //public string Feeling { get; set; }
    }
}
