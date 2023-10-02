using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuperHeroes.Models;

namespace SuperHeroes.Data.ContextConfigurations
{
    public class SuperpowerContextConfiguration : IEntityTypeConfiguration<Superpower>
    {
        private Guid[] _ids;
        public SuperpowerContextConfiguration(Guid[] ids) 
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Superpower> builder)
        {
            builder
                .HasData(
                new Superpower 
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Superhuman Speed",
                    Description = "Superhuman speed is the ability to move, react, and operate at speeds far beyond those of ordinary humans. Individuals with this power can run, fly, or perform any physical activity at velocities that exceed the capabilities of normal human beings. This power often grants the user enhanced reflexes, allowing them to perceive and react to events in the blink of an eye. Superhuman speed is a versatile ability, useful in combat, rescue missions, and various other situations.",
                    SuperheroId = _ids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Heat Vision",
                    Description = "Heat vision is a superpower that allows an individual to emit beams of intense heat and energy from their eyes. This ability enables the user to generate focused beams that can reach extremely high temperatures, capable of melting or vaporizing objects. Heat vision is often depicted as red or orange beams that emanate from the eyes. Characters with this power can use it for offensive purposes, such as attacking adversaries, and for practical applications like welding or cutting through obstacles.",
                    SuperheroId = _ids[0]
                },
                new Superpower
                {
                    Id = Guid.NewGuid(),
                    SuperPower = "Super Hearing",
                    Description = "Super hearing is a heightened auditory ability that allows individuals to perceive sounds at frequencies and volumes beyond the normal human range. Characters with super hearing can detect faint sounds from great distances, hear frequencies outside the human spectrum, and focus on specific sounds amidst background noise. This power grants users an extraordinary level of situational awareness, making them adept at eavesdropping, detecting hidden threats, and responding to emergencies based on auditory cues. Super hearing is a valuable asset in crime-fighting and surveillance.",
                    SuperheroId = _ids[0]
                });
        }
    }
}
