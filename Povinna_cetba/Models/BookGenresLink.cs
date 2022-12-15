namespace Povinna_cetba.Models
{
    public class BookGenresLink
    {
        public int Id { get; set; }
        public int BooklId { get; set; }
        public Book Book { get; set; } = new Book();
        public int GenreId { get; set; }
        public Genre Genre { get; set; } = new Genre();
    }
}
