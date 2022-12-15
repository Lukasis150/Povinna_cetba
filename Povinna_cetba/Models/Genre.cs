using Microsoft.Build.Framework;
using Povinna_cetba.Enums;

namespace Povinna_cetba.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public BookGenre Name { get; set; }
        public List<BookGenresLink> BookLinks { get; set; } = new List<BookGenresLink>();
    }
}
