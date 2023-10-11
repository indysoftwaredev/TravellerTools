using Traveller.API.Data.DbContexts;

namespace Traveller.API.Services.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly TravellerDbContext skillDbContext;

        public SkillRepository(TravellerDbContext skillDbContext)
        {
            skillDbContext = skillDbContext;
        }

    }
}
