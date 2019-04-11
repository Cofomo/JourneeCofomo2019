using System.Collections.Generic;

namespace TheBookClub.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Genre { get; set; }

        public string Author { get; set; }

        public ICollection<Comment> Comments { get; set; }        
    }
}