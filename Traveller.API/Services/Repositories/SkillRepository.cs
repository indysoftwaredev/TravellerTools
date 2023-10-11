using Traveller.API.Data.DbContexts;

namespace Traveller.API.Services.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly SkillDbContext _skillDbContext;
        private readonly SkillSpecializationDbContext _skillSpecializationDbContext;

        public SkillRepository(SkillDbContext skillDbContext,
            SkillSpecializationDbContext skillSpecializationDbContext)
        {
            _skillDbContext = skillDbContext;
            _skillSpecializationDbContext = skillSpecializationDbContext;
        }

    }
}
