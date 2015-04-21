using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
