using System.Collections.Generic;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile Add(Profile profile);
        Profile GetProfileById(string profileId);
        Profile GetProfileByUserId(string userId);
        Profile Update(Profile profile);
    }
}
