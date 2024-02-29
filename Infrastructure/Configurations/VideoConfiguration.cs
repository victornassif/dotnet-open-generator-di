using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Open_Generics_Dependency_Injection.Models;

namespace Open_Generics_Dependency_Injection.Infrastructure.Configurations
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasData(new List<Video>{
                new Video
                {
                    Id = 1,
                    Author = "Isaac Varzim",
                    Description = "Mix of brazilian songs build for chilling vibes",
                    Title = "Chill Brasil Mix - a sunset in Brazil set",
                    Url = "https://www.youtube.com/watch?v=rILP7u06XvE",
                    CreatedAt = DateTime.Now.AddDays(-3)
                },
                new Video
                {
                    Id = 2,
                    Author = "My Analog Journal",
                    Description = "Part of the new generation of Brazilian researchers, Lucian Fernandes expands musical borders in time and space, bringing combinations of Brazilian, world music and versions in a multitude of genres and atmospheres.\r\n\r\nLucian is bringing you the 90s Brazilian hiphop B-side love songs. Mixing rap, pop and R&B with strong and hypnotic electronic drum beats, Street Soul echoed in Brazilian music production, leaving gems for the dance floors. We hope you enjoy this trip to the ‘90s with the holiest of Brazilian Street Soul.\r\n",
                    Title = "Brazilian Street Soul with Lucian Fernandes",
                    Url = "https://www.youtube.com/watch?v=NZjyhK8SDds",
                    CreatedAt = DateTime.Now.AddDays(-30)
                }
            });
        }
    }
}
