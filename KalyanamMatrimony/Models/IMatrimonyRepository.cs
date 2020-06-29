using System.Collections.Generic;
using System.Linq;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile Add(Profile profile);
        Profile GetProfileById(string profileId);
        Profile GetProfileByUserId(string userId);
        Profile Update(Profile profile);
        IEnumerable<Profile> GetActiveProfiles(IQueryable<ApplicationUser> userList);
        IEnumerable<Profile> GetDeActivedProfiles(IQueryable<ApplicationUser> userList);
    }
}
