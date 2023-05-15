namespace OneToOneDemoCodeFirst.Models
{
    public class AuthorBio
    {
        public int AuthorBioId { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceofBirth { get; set; }
        public string Nationality { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
    }
}
