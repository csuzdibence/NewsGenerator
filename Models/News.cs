namespace NewsGenerator.Models
{
    public class News
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string OriginalNewsLink { get; set; }

        public string ImageLink { get; set; }

        public string Source { get; set; }
    }
}
