using Microsoft.Build.Framework;

namespace Povinna_cetba.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int PageCount { get; set; }
        public int Year { get; set; }
        public List<BookGenresLink> GenreLinks { get; set; } = new List<BookGenresLink>();
        public List<StudentBooksLink> StudentLinks { get; set; } = new List<StudentBooksLink>();
    }
}
