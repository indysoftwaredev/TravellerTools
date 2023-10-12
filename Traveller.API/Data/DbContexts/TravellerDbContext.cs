using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.Entities;

namespace Traveller.API.Data.DbContexts
{
    public class TravellerDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillSpecialization> skillSpecializations { get; set; }

        public TravellerDbContext(DbContextOptions<TravellerDbContext> options) : base(options)
        {          
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(GetSkills());
            modelBuilder.Entity<SkillSpecialization>().HasData(GetSkillSpecializations());
        }       

        private List<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill
                {
                    Id = 1,
                    Name = "Admin",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 2, 
                    Name = ""
                },
                new Skill
                {
                    Id = 3,
                    Name = "Animals",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 4,
                    Name = "Art",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 5,
                    Name = "Astrogation"
                },
                new Skill
                {
                    Id = 6,
                    Name = "Athletics",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 7,
                    Name = "Broker"
                },
                new Skill
                {
                    Id = 8,
                    Name = "Carouse",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 9,
                    Name = "Deception"
                },
                new Skill
                {
                    Id = 10,
                    Name = "Diplomat"
                },
                new Skill
                {
                    Id = 11,
                    Name = "Drive",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 12,
                    Name = "Electronics",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 13,
                    Name = "Explosives"
                },
                new Skill
                {
                    Id = 14,
                    Name = "Flyer",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 15,
                    Name = "Gambler"
                },
                new Skill
                {
                    Id = 16,
                    Name = "Gunner"
                },
                new Skill
                {
                    Id = 17,
                    Name = "Gun Combat"
                },
                new Skill
                {
                    Id = 18,
                    Name = "Heavy Weapons"
                },
                new Skill
                {
                    Id = 19,
                    Name = "Investigate"
                },
                new Skill
                {
                    Id = 20,
                    Name = "Jack-Of-All-Trades"
                },
                new Skill
                {
                    Id = 21,
                    Name = "Language",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 22,
                    Name = "Leadership"
                },
                new Skill
                {
                    Id = 23,
                    Name = "Mechanic",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 24,
                    Name = "Medic",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 25,
                    Name = "Melee"
                },
                new Skill
                {
                    Id = 26,
                    Name = "Navigation"
                },
                new Skill
                {
                    Id = 27,
                    Name = "Persuade"
                },
                new Skill
                {
                    Id = 28,
                    Name = "Pilot"
                },
                new Skill
                {
                    Id = 29,
                    Name = "Profession",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 30,
                    Name = "Recon"
                },
                new Skill
                {
                    Id = 31,
                    Name = "Science",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 32,
                    Name = "Seafarer",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 33,
                    Name = "Stealth"
                },
                new Skill
                {
                    Id = 34,
                    Name = "Steward"
                },
                new Skill
                {
                    Id = 35,
                    Name = "Streetwise",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 36,
                    Name = "Survival",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Id = 37,
                    Name = "Tactics"
                },
                new Skill
                {
                    Id = 38,
                    Name = "Vacc Suit",
                    IsBackgroundSkill = true
                }
            };
        }
        private List<SkillSpecialization> GetSkillSpecializations()
        {
            return new List<SkillSpecialization>
            {
                new SkillSpecialization
                {
                    Id = 1,
                    SkillId = 3,
                    Name = "Handling"
                },
                new SkillSpecialization
                {
                    Id = 2,
                    SkillId = 3,
                    Name = "Veterinary"
                },
                new SkillSpecialization
                {
                    Id = 3,
                    SkillId = 3,
                    Name = "Training"
                },
                new SkillSpecialization
                {
                    Id = 4,
                    SkillId = 4,
                    Name = "Performer"
                },
                new SkillSpecialization
                {
                    Id = 5,
                    SkillId = 4,
                    Name = "Holography"
                },
                new SkillSpecialization
                {
                    Id = 6,
                    SkillId = 4,
                    Name = "Instrument"
                },
                new SkillSpecialization
                {
                    Id = 7,
                    SkillId = 4,
                    Name = "Visual Media"
                },
                new SkillSpecialization
                {
                    Id = 8,
                    SkillId = 4,
                    Name = "Write"
                },
                new SkillSpecialization
                {
                    Id = 9,
                    SkillId = 6,
                    Name = "Dexterity"
                },
                new SkillSpecialization
                {
                    Id = 10,
                    SkillId = 6,
                    Name = "Endurance"
                },
                new SkillSpecialization
                {
                    Id = 11,
                    SkillId = 6,
                    Name = "Strength"
                },
                new SkillSpecialization
                {
                    Id = 12,
                    SkillId = 11,
                    Name = "Hovercraft"
                },
                new SkillSpecialization
                {
                    Id = 13,
                    SkillId = 11,
                    Name = "Mole"
                },
                new SkillSpecialization
                {
                    Id = 14,
                    SkillId = 11,
                    Name = "Track"
                },
                new SkillSpecialization
                {
                    Id = 15,
                    SkillId = 11,
                    Name = "Walker"
                },
                new SkillSpecialization
                {
                    Id = 16,
                    SkillId = 11,
                    Name = "Wheel"
                },
                new SkillSpecialization
                {
                    Id = 17,
                    SkillId = 12,
                    Name = "Comms"
                },
                new SkillSpecialization
                {
                    Id = 18,
                    SkillId = 12,
                    Name = "Computers"
                },
                new SkillSpecialization
                {
                    Id = 19,
                    SkillId = 12,
                    Name = "Remote Ops"
                },
                new SkillSpecialization
                {
                    Id = 20,
                    SkillId = 12,
                    Name = "Sensors"
                },
                new SkillSpecialization
                {
                    Id = 21,
                    SkillId = 14,
                    Name = "Airship"
                },
                new SkillSpecialization
                {
                    Id = 22,
                    SkillId = 14,
                    Name = "Grav"
                },
                new SkillSpecialization
                {
                    Id = 23,
                    SkillId = 14,
                    Name = "Ornithopter"
                },
                new SkillSpecialization
                {
                    Id = 24,
                    SkillId = 14,
                    Name = "Rotor"
                },
                new SkillSpecialization
                {
                    Id = 25,
                    SkillId = 14,
                    Name = "Wing"
                },
                new SkillSpecialization
                {
                    Id = 26,
                    SkillId = 16,
                    Name = "Turret"
                },
                new SkillSpecialization
                {
                    Id = 27,
                    SkillId = 16,
                    Name = "Ortillery"
                },
                new SkillSpecialization
                {
                    Id = 28,
                    SkillId = 16,
                    Name = "Screen"
                },
                new SkillSpecialization
                {
                    Id = 29,
                    SkillId = 16,
                    Name = "Capital"
                },
                new SkillSpecialization
                {
                    Id = 30,
                    SkillId = 17,
                    Name = "Archaic"
                },
                new SkillSpecialization
                {
                    Id = 31,
                    SkillId = 17,
                    Name = "Energy"
                },
                new SkillSpecialization
                {
                    Id = 32,
                    SkillId = 17,
                    Name = "Slug"
                },
                new SkillSpecialization
                {
                    Id = 33,
                    SkillId = 18,
                    Name = "Artillery"
                },
                new SkillSpecialization
                {
                    Id = 34,
                    SkillId = 18,
                    Name = "Portable"
                },
                new SkillSpecialization
                {
                    Id = 35,
                    SkillId = 18,
                    Name = "Vehicle"
                },
                new SkillSpecialization
                {
                    Id = 36,
                    SkillId = 21,
                    Name = "Galanglic"
                },
                new SkillSpecialization
                {
                    Id = 37,
                    SkillId = 21,
                    Name = "Vilani"
                },
                new SkillSpecialization
                {
                    Id = 38,
                    SkillId = 21,
                    Name = "Zdetl"
                },
                new SkillSpecialization
                {
                    Id = 39,
                    SkillId = 21,
                    Name = "Oynprith"
                },
                new SkillSpecialization
                {
                    Id = 40,
                    SkillId = 21,
                    Name = "Trokh"
                },
                new SkillSpecialization
                {
                    Id = 41,
                    SkillId = 21,
                    Name = "Gvegh"
                },
                new SkillSpecialization
                {
                    Id = 42,
                    SkillId = 25,
                    Name = "Unarmed"
                },
                new SkillSpecialization
                {
                    Id = 43,
                    SkillId = 25,
                    Name = "Blade"
                },
                new SkillSpecialization
                {
                    Id = 44,
                    SkillId = 25,
                    Name = "Bludgeon"
                },
                new SkillSpecialization
                {
                    Id = 45,
                    SkillId = 25,
                    Name = "Natural"
                },
                new SkillSpecialization
                {
                    Id = 46,
                    SkillId = 28,
                    Name = "Small Craft"
                },
                new SkillSpecialization
                {
                    Id = 47,
                    SkillId = 28,
                    Name = "Spacecraft"
                },
                new SkillSpecialization
                {
                    Id = 48,
                    SkillId = 28,
                    Name = "Capital Ships"
                },
                new SkillSpecialization
                {
                    Id = 49,
                    SkillId = 29,
                    Name = "Belter"
                },
                new SkillSpecialization
                {
                    Id = 50,
                    SkillId = 29,
                    Name = "Biologicals"
                },
                new SkillSpecialization
                {
                    Id = 51,
                    SkillId = 29,
                    Name = "Civil Engineering"
                },
                new SkillSpecialization
                {
                    Id = 52,
                    SkillId = 29,
                    Name = "Construction"
                },
                new SkillSpecialization
                {
                    Id = 53,
                    SkillId = 29,
                    Name = "Hydroponics"
                },
                new SkillSpecialization
                {
                    Id = 54,
                    SkillId = 29,
                    Name = "Polymers"
                },
                new SkillSpecialization
                {
                    Id = 55,
                    SkillId = 31,
                    Name = "Archaeology"
                },
                new SkillSpecialization
                {
                    Id = 56,
                    SkillId = 31,
                    Name = "Astronomy"
                },
                new SkillSpecialization
                {
                    Id = 57,
                    SkillId = 31,
                    Name = "Biology"
                },
                new SkillSpecialization
                {
                    Id = 58,
                    SkillId = 31,
                    Name = "Chemistry"
                },
                new SkillSpecialization
                {
                    Id = 59,
                    SkillId = 31,
                    Name = "Cosmology"
                },
                new SkillSpecialization
                {
                    Id = 60,
                    SkillId = 31,
                    Name = "Cybernetics"
                },
                new SkillSpecialization
                {
                    Id = 61,
                    SkillId = 31,
                    Name = "Economics"
                },
                new SkillSpecialization
                {
                    Id = 62,
                    SkillId = 31,
                    Name = "Genetics"
                },
                new SkillSpecialization
                {
                    Id = 63,
                    SkillId = 31,
                    Name = "History"
                },
                new SkillSpecialization
                {
                    Id = 64,
                    SkillId = 31,
                    Name = "Linguistics"
                },
                new SkillSpecialization
                {
                    Id = 65,
                    SkillId = 31,
                    Name = "Philosophy"
                },
                new SkillSpecialization
                {
                    Id = 66,
                    SkillId = 31,
                    Name = "Physics"
                },
                new SkillSpecialization
                {
                    Id = 67,
                    SkillId = 31,
                    Name = "Planetology"
                },
                new SkillSpecialization
                {
                    Id = 68,
                    SkillId = 31,
                    Name = "Psionicology"
                },
                new SkillSpecialization
                {
                    Id = 69,
                    SkillId = 31,
                    Name = "Psychology"
                },
                new SkillSpecialization
                {
                    Id = 70,
                    SkillId = 31,
                    Name = "Robotics"
                },
                new SkillSpecialization
                {
                    Id = 71,
                    SkillId = 31,
                    Name = "Sophontology"
                },
                new SkillSpecialization
                {
                    Id = 72,
                    SkillId = 31,
                    Name = "Xenology"
                },
                new SkillSpecialization
                {
                    Id = 73,
                    SkillId = 32,
                    Name = "Ocean Ships"
                },
                new SkillSpecialization
                {
                    Id = 74,
                    SkillId = 32,
                    Name = "Personal"
                },
                new SkillSpecialization
                {
                    Id = 75,
                    SkillId = 32,
                    Name = "Sail"
                },
                new SkillSpecialization
                {
                    Id = 76,
                    SkillId = 32,
                    Name = "Submarine"
                },
                new SkillSpecialization
                {
                    Id = 77,
                    SkillId = 37,
                    Name = "Military"
                },
                new SkillSpecialization
                {
                    Id = 78,
                    SkillId = 37,
                    Name = "Naval"
                }
            };
        }
    }
}
