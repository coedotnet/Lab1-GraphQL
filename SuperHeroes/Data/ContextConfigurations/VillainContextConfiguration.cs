using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes.Models;

namespace SuperHeroes.Data.ContextConfigurations
{
    public class VillainContextConfiguration : IEntityTypeConfiguration<Villain>
    {
        private Guid[] _ids;

        public VillainContextConfiguration(Guid[] ids) 
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Villain> builder) 
        {
            builder
                .HasData(
                new Villain
                {
                    Id = Guid.NewGuid(),
                    Name = "Lex Luthor",
                    Background = "A brilliant and wealthy businessman who despises Superman",
                    SuperheroId = _ids[0]
                },
                new Villain
                {
                    Id = Guid.NewGuid(),
                    Name = "General Zod",
                    Background = "A Kryptonian military leader with superhuman abilities similar to Superman. Zod seeks to establish Kryptonian dominance on Earth and considers Superman an obstacle.",
                    SuperheroId = _ids[0]
                });
        }
    }
}
