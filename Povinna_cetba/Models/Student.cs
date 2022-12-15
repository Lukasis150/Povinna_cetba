using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Build.Framework;

namespace Povinna_cetba.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public Book ActualBook { get; set; } = new Book();
        public List<StudentBooksLink> BookLinks { get; set; } = new List<StudentBooksLink>();
    }
}
