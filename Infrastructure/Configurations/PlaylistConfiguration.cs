using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Open_Generics_Dependency_Injection.Models;

namespace Open_Generics_Dependency_Injection.Infrastructure.Configurations
{
    public class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasData(
                new List<Playlist> { 
                    new Playlist{Id =1, Description ="", Title="", VideoList=new List<Video>()},
                    //new Playlist{ },
                    );
        }
    }
}
