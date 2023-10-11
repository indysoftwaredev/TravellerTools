using Traveller.API.Data.DbContexts;

namespace Traveller.API.Services.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly SkillDbContext _skillDbContext;

        public SkillRepository(SkillDbContext skillDbContext)
        {
            _skillDbContext = skillDbContext;
        }

    }
}
