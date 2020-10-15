using System;
using System.Collections.Generic;

namespace BookTP.Models
{
    public class Shelve
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
