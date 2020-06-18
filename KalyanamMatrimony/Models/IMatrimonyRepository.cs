using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public interface IMatrimonyRepository
    {
        IEnumerable<Profile> GetAllProfiles();
        Profile Add(Profile profile);
    }
}
