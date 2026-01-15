
namespace ASP_NET_L3.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public int PublishYear { get; set; }

        public decimal? Price { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

    }
}
