using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace TheBookClub.Models
{
    public class BookClubContext: DbContext
    {
        public BookClubContext(DbContextOptions<BookClubContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}