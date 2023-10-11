using Microsoft.EntityFrameworkCore;
using Traveller.API.Data.Entities;

namespace Traveller.API.Data.DbContexts
{
    public class SkillSpecializationDbContext : DbContext
    {
        public DbSet<SkillSpecialization> SkillSpecializations { get; set; }

        public SkillSpecializationDbContext(DbContextOptions<SkillSpecializationDbContext> options) 
            : base(options)
        {
            
        }
    }
}
