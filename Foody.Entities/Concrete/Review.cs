
namespace Foody.Entities.Concrete
{
    public class Review
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}