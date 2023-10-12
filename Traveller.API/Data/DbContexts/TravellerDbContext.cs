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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 1,
                            Name = "Handling"
                        },
                        new SkillSpecialization
                        {
                            Id = 2,
                            Name = "Veterinary"
                        },
                        new SkillSpecialization
                        {
                            Id = 3,
                            Name = "Training"
                        }
                    }
                },
                new Skill
                {
                    Id = 4,
                    Name = "Art",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization> 
                    {
                        new SkillSpecialization
                        {
                            Id = 4,
                            Name = "Performer"
                        },
                        new SkillSpecialization
                        {
                            Id = 5,
                            Name = "Holography"
                        },
                        new SkillSpecialization
                        {
                            Id = 6,
                            Name = "Instrument"
                        },
                        new SkillSpecialization
                        {
                            Id = 7,
                            Name = "Visual Media"
                        },
                        new SkillSpecialization
                        {
                            Id = 8,
                            Name = "Write"
                        }
                    }
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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 9,
                            Name = "Dexterity"
                        },
                        new SkillSpecialization
                        {
                            Id = 10,
                            Name = "Endurance"
                        },
                        new SkillSpecialization
                        {
                            Id = 11,
                            Name = "Strength"
                        }
                    }                    
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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 12,
                            Name = "Hovercraft"
                        },
                        new SkillSpecialization
                        {
                            Id = 13,
                            Name = "Mole"
                        },
                        new SkillSpecialization
                        {
                            Id = 14,
                            Name = "Track"
                        },
                        new SkillSpecialization
                        {
                            Id = 15,
                            Name = "Walker"
                        },
                        new SkillSpecialization
                        {
                            Id = 16,
                            Name = "Wheel"
                        }
                    }
                },
                new Skill
                {
                    Id = 12,
                    Name = "Electronics",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 17,
                            Name = "Comms"
                        },
                        new SkillSpecialization
                        {
                            Id = 18,
                            Name = "Computers"
                        },
                        new SkillSpecialization
                        {
                            Id = 19,
                            Name = "Remote Ops"
                        },
                        new SkillSpecialization
                        {
                            Id = 20,
                            Name = "Sensors"
                        }
                    }
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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 21,
                            Name = "Airship"
                        },
                        new SkillSpecialization
                        {
                            Id = 22,
                            Name = "Grav"
                        },
                        new SkillSpecialization
                        {
                            Id = 23,
                            Name = "Ornithopter"
                        },
                        new SkillSpecialization
                        {
                            Id = 24,
                            Name = "Rotor"
                        },
                        new SkillSpecialization
                        {
                            Id = 25,
                            Name = "Wing"
                        }
                    }
                },
                new Skill
                {
                    Id = 15,
                    Name = "Gambler"
                },
                new Skill
                {
                    Id = 16,
                    Name = "Gunner",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 26,
                            Name = "Turret"
                        },
                        new SkillSpecialization
                        {
                            Id = 27,
                            Name = "Ortillery"
                        },
                        new SkillSpecialization
                        {
                            Id = 28,
                            Name = "Screen"
                        },
                        new SkillSpecialization
                        {
                            Id = 29,
                            Name = "Capital"
                        }
                    }
                },
                new Skill
                {
                    Id = 17,
                    Name = "Gun Combat",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 30,
                            Name = "Archaic"
                        },
                        new SkillSpecialization
                        {
                            Id = 31,
                            Name = "Energy"
                        },
                        new SkillSpecialization
                        {
                            Id = 32,
                            Name = "Slug"
                        }
                    }
                },
                new Skill
                {
                    Id = 18,
                    Name = "Heavy Weapons",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 33,
                            Name = "Artillery"
                        },
                        new SkillSpecialization
                        {
                            Id = 34,
                            Name = "Portable"
                        },
                        new SkillSpecialization
                        {
                            Id = 35,
                            Name = "Vehicle"
                        }
                    }
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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 36,
                            Name = "Galanglic"
                        },
                        new SkillSpecialization
                        {
                            Id = 37,
                            Name = "Vilani"
                        },
                        new SkillSpecialization
                        {
                            Id = 38,
                            Name = "Zdetl"
                        },
                        new SkillSpecialization
                        {
                            Id = 39,
                            Name = "Oynprith"
                        },
                        new SkillSpecialization
                        {
                            Id = 40,
                            Name = "Trokh"
                        },
                        new SkillSpecialization
                        {
                            Id = 41,
                            Name = "Gvegh"
                        }
                    }
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
                    Name = "Melee",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 42,
                            Name = "Unarmed"
                        },
                        new SkillSpecialization
                        {
                            Id = 42,
                            Name = "Blade"
                        },
                        new SkillSpecialization
                        {
                            Id = 43,
                            Name = "Bludgeon"
                        },
                        new SkillSpecialization
                        {
                            Id = 44,
                            Name = "Natural"
                        }
                    }
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
                    Name = "Pilot",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 45,
                            Name = "Small Craft"
                        },
                        new SkillSpecialization
                        {
                            Id = 45,
                            Name = "Spacecraft"
                        },
                        new SkillSpecialization
                        {
                            Id = 46,
                            Name = "Capital Ships"
                        }
                    }
                },
                new Skill
                {
                    Id = 29,
                    Name = "Profession",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 47,
                            Name = "Belter"
                        },
                        new SkillSpecialization
                        {
                            Id = 48,
                            Name = "Biologicals"
                        },
                        new SkillSpecialization
                        {
                            Id = 49,
                            Name = "Civil Engineering"
                        },
                        new SkillSpecialization
                        {
                            Id = 50,
                            Name = "Construction"
                        },
                        new SkillSpecialization
                        {
                            Id = 51,
                            Name = "Hydroponics"
                        },
                        new SkillSpecialization
                        {
                            Id = 52,
                            Name = "Polymers"
                        }
                    }
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
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 53,
                            Name = "Archaeology"
                        },
                        new SkillSpecialization
                        {
                            Id = 54,
                            Name = "Astronomy"
                        },
                        new SkillSpecialization
                        {
                            Id = 55,
                            Name = "Biology"
                        },
                        new SkillSpecialization
                        {
                            Id = 56,
                            Name = "Chemistry"
                        },
                        new SkillSpecialization
                        {
                            Id = 57,
                            Name = "Cosmology"
                        },
                        new SkillSpecialization
                        {
                            Id = 58,
                            Name = "Cybernetics"
                        },
                        new SkillSpecialization
                        {
                            Id = 59,
                            Name = "Economics"
                        },
                        new SkillSpecialization
                        {
                            Id = 60,
                            Name = "Genetics"
                        },
                        new SkillSpecialization
                        {
                            Id = 61,
                            Name = "History"
                        },
                        new SkillSpecialization
                        {
                            Id = 62,
                            Name = "Linguistics"
                        },
                        new SkillSpecialization
                        {
                            Id = 63,
                            Name = "Philosophy"
                        },
                        new SkillSpecialization
                        {
                            Id = 64,
                            Name = "Physics"
                        },
                        new SkillSpecialization
                        {
                            Id = 65,
                            Name = "Planetology"
                        },
                        new SkillSpecialization
                        {
                            Id = 66,
                            Name = "Psionicology"
                        },
                        new SkillSpecialization
                        {
                            Id = 67,
                            Name = "Psychology"
                        },
                        new SkillSpecialization
                        {
                            Id = 68,
                            Name = "Robotics"
                        },
                        new SkillSpecialization
                        {
                            Id = 69,
                            Name = "Sophontology"
                        },
                        new SkillSpecialization
                        {
                            Id = 70,
                            Name = "Xenology"
                        }
                    }
                },
                new Skill
                {
                    Id = 32,
                    Name = "Seafarer",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 71,
                            Name = "Ocean Ships"
                        },
                        new SkillSpecialization
                        {
                            Id = 72,
                            Name = "Personal"
                        },
                        new SkillSpecialization
                        {
                            Id = 73,
                            Name = "Sail"
                        },
                        new SkillSpecialization
                        {
                            Id = 74,
                            Name = "Submarine"
                        }
                    }
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
                    Name = "Tactics", 
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Id = 75,
                            Name = "Military"
                        },
                        new SkillSpecialization
                        {
                            Id = 76,
                            Name = "Naval"
                        }
                    }
                },
                new Skill
                {
                    Id = 38,
                    Name = "Vacc Suit",
                    IsBackgroundSkill = true
                }
            };
        }
    }
}
