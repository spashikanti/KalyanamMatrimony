using Microsoft.EntityFrameworkCore;
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

        public Profile GetProfileById(string profileId)
        {
            return context.Profiles.FirstOrDefault(x => x.ProfileId == profileId);
        }

        public Profile Update(Profile profile)
        {
            context.Profiles.Update(profile);
            context.Entry(profile).State = EntityState.Modified;
            context.SaveChanges();
            return profile;
        }
    }
}
