using static Povinna_cetba.Enums.StudentEnums;

namespace Povinna_cetba.Models
{
    public class StudentBooksLink
    {
        public int Id { get; set; }
        public int StudentlId { get; set; }
        public Student Student { get; set; } = new Student();
        public int BookId { get; set; }
        public Book Book { get; set; } = new Book();
        public BookState State { get; set; }
    }
}
