namespace Open_Generics_Dependency_Injection.Models
{
    public class Video
    {
        public int Id { get; set; }
        public required string Url { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Author { get; set; }
        public required DateTime CreatedAt { get; set; }
    }
}
