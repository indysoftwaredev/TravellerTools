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
                    Name = "Admin",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = ""
                },
                new Skill
                {
                    Name = "Animals",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Handling"
                        },
                        new SkillSpecialization
                        {
                            Name = "Veterinary"
                        },
                        new SkillSpecialization
                        {
                            Name = "Training"
                        }
                    }
                },
                new Skill
                {
                    Name = "Art",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization> 
                    {
                        new SkillSpecialization
                        {
                            Name = "Performer"
                        },
                        new SkillSpecialization
                        {
                            Name = "Holography"
                        },
                        new SkillSpecialization
                        {
                            Name = "Instrument"
                        },
                        new SkillSpecialization
                        {
                            Name = "Visual Media"
                        },
                        new SkillSpecialization
                        {
                            Name = "Write"
                        }
                    }
                },
                new Skill
                {
                    Name = "Astrogation"
                },
                new Skill
                {
                    Name = "Athletics",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Dexterity"
                        },
                        new SkillSpecialization
                        {
                            Name = "Endurance"
                        },
                        new SkillSpecialization
                        {
                            Name = "Strength"
                        }
                    }                    
                },
                new Skill
                {
                    Name = "Broker"
                },
                new Skill
                {
                    Name = "Carouse",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = "Deception"
                },
                new Skill
                {
                    Name = "Diplomat"
                },
                new Skill
                {
                    Name = "Drive",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Hovercraft"
                        },
                        new SkillSpecialization
                        {
                            Name = "Mole"
                        },
                        new SkillSpecialization
                        {
                            Name = "Track"
                        },
                        new SkillSpecialization
                        {
                            Name = "Walker"
                        },
                        new SkillSpecialization
                        {
                            Name = "Wheel"
                        }
                    }
                },
                new Skill
                {
                    Name = "Electronics",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Comms"
                        },
                        new SkillSpecialization
                        {
                            Name = "Computers"
                        },
                        new SkillSpecialization
                        {
                            Name = "Remote Ops"
                        },
                        new SkillSpecialization
                        {
                            Name = "Sensors"
                        }
                    }
                },
                new Skill
                {
                    Name = "Explosives"
                },
                new Skill
                {
                    Name = "Flyer",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Airship"
                        },
                        new SkillSpecialization
                        {
                            Name = "Grav"
                        },
                        new SkillSpecialization
                        {
                            Name = "Ornithopter"
                        },
                        new SkillSpecialization
                        {
                            Name = "Rotor"
                        },
                        new SkillSpecialization
                        {
                            Name = "Wing"
                        }
                    }
                },
                new Skill
                {
                    Name = "Gambler"
                },
                new Skill
                {
                    Name = "Gunner",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Turret"
                        },
                        new SkillSpecialization
                        {
                            Name = "Ortillery"
                        },
                        new SkillSpecialization
                        {
                            Name = "Screen"
                        },
                        new SkillSpecialization
                        {
                            Name = "Capital"
                        }
                    }
                },
                new Skill
                {
                    Name = "Gun Combat",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Archaic"
                        },
                        new SkillSpecialization
                        {
                            Name = "Energy"
                        },
                        new SkillSpecialization
                        {
                            Name = "Slug"
                        }
                    }
                },
                new Skill
                {
                    Name = "Heavy Weapons",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Artillery"
                        },
                        new SkillSpecialization
                        {
                            Name = "Portable"
                        },
                        new SkillSpecialization
                        {
                            Name = "Vehicle"
                        }
                    }
                },
                new Skill
                {
                    Name = "Investigate"
                },
                new Skill
                {
                    Name = "Jack-Of-All-Trades"
                },
                new Skill
                {
                    Name = "Language",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Galanglic"
                        },
                        new SkillSpecialization
                        {
                            Name = "Vilani"
                        },
                        new SkillSpecialization
                        {
                            Name = "Zdetl"
                        },
                        new SkillSpecialization
                        {
                            Name = "Oynprith"
                        },
                        new SkillSpecialization
                        {
                            Name = "Trokh"
                        },
                        new SkillSpecialization
                        {
                            Name = "Gvegh"
                        }
                    }
                },
                new Skill
                {
                    Name = "Leadership"
                },
                new Skill
                {
                    Name = "Mechanic",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = "Medic",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = "Melee",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Unarmed"
                        },
                        new SkillSpecialization
                        {
                            Name = "Blade"
                        },
                        new SkillSpecialization
                        {
                            Name = "Bludgeon"
                        },
                        new SkillSpecialization
                        {
                            Name = "Natural"
                        }
                    }
                },
                new Skill
                {
                    Name = "Navigation"
                },
                new Skill
                {
                    Name = "Persuade"
                },
                new Skill
                {
                    Name = "Pilot",
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Small Craft"
                        },
                        new SkillSpecialization
                        {
                            Name = "Spacecraft"
                        },
                        new SkillSpecialization
                        {
                            Name = "Capital Ships"
                        }
                    }
                },
                new Skill
                {
                    Name = "Profession",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Belter"
                        },
                        new SkillSpecialization
                        {
                            Name = "Biologicals"
                        },
                        new SkillSpecialization
                        {
                            Name = "Civil Engineering"
                        },
                        new SkillSpecialization
                        {
                            Name = "Construction"
                        },
                        new SkillSpecialization
                        {
                            Name = "Hydroponics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Polymers"
                        }
                    }
                },
                new Skill
                {
                    Name = "Recon"
                },
                new Skill
                {
                    Name = "Science",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Archaeology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Astronomy"
                        },
                        new SkillSpecialization
                        {
                            Name = "Biology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Chemistry"
                        },
                        new SkillSpecialization
                        {
                            Name = "Cosmology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Cybernetics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Economics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Genetics"
                        },
                        new SkillSpecialization
                        {
                            Name = "History"
                        },
                        new SkillSpecialization
                        {
                            Name = "Linguistics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Philosophy"
                        },
                        new SkillSpecialization
                        {
                            Name = "Physics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Planetology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Psionicology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Psychology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Robotics"
                        },
                        new SkillSpecialization
                        {
                            Name = "Sophontology"
                        },
                        new SkillSpecialization
                        {
                            Name = "Xenology"
                        }
                    }
                },
                new Skill
                {
                    Name = "Seafarer",
                    IsBackgroundSkill = true,
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Ocean Ships"
                        },
                        new SkillSpecialization
                        {
                            Name = "Personal"
                        },
                        new SkillSpecialization
                        {
                            Name = "Sail"
                        },
                        new SkillSpecialization
                        {
                            Name = "Submarine"
                        }
                    }
                },
                new Skill
                {
                    Name = "Stealth"
                },
                new Skill
                {
                    Name = "Steward"
                },
                new Skill
                {
                    Name = "Streetwise",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = "Survival",
                    IsBackgroundSkill = true
                },
                new Skill
                {
                    Name = "Tactics", 
                    SkillSpecializations = new List<SkillSpecialization>
                    {
                        new SkillSpecialization
                        {
                            Name = "Military"
                        },
                        new SkillSpecialization
                        {
                            Name = "Naval"
                        }
                    }
                },
                new Skill
                {
                    Name = "Vacc Suit",
                    IsBackgroundSkill = true
                }
            };
        }
    }
}
