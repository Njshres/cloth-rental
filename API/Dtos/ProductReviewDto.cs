namespace API.Dtos
{
    public class ProductReviewDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
    }

    public class CanComment
    {
        public string Email { get; set; }
    }
}