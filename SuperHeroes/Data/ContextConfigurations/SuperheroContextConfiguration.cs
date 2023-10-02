using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes.Models;

namespace SuperHeroes.Data.ContextConfigurations
{
    public class SuperheroContextConfiguration : IEntityTypeConfiguration<Superhero>
    {
        private Guid[] _ids;

        public SuperheroContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            builder
                .HasData(
                new Superhero
                {
                    Id = _ids[0],
                    Name = "Superman",
                    RealName = "Clark Kent",
                    Description = "Last Son of Krypton with superhuman strength and more.",
                    ComicUniverse = "DC"
                });
        }
    }
}
