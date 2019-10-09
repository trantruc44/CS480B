using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    public class quotableData
    {
        public int ID { get; set; }
        public string Quote { get; set; }
        public string Author { get; set; }
        public quotableData (int id, string quote, string author)
        {
            ID = id;
            Quote = quote;
            Author = author;
        }
    }
}
