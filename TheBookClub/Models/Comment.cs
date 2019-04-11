namespace TheBookClub.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Username { get; set; }

         public int BookId { get; set; }

        public Book Book { get; set; }
    }
}