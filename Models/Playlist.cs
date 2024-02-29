using System.ComponentModel.DataAnnotations;

namespace Open_Generics_Dependency_Injection.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }
        public required IEnumerable<Video> VideoList { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
