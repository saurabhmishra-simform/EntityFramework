using System.ComponentModel.DataAnnotations;

namespace OneToOneDemoCodeFirst.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public AuthorBio? Bio { get; set; }
    }
}
