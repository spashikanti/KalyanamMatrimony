using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class MySqlMatrimonyRepository : IMatrimonyRepository
    {
        private readonly AppDbContext context;

        public MySqlMatrimonyRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Profile Add(Profile profile)
        {
            context.Profiles.Add(profile);
            context.SaveChanges();
            return profile;
        }

        public IEnumerable<Profile> GetAllProfiles()
        {
            return context.Profiles.OrderBy(x => x.CreatedDate);
        }
    }
}
