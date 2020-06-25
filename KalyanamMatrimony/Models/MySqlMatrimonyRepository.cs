﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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

        //public IEnumerable<Profile> GetLatestProfiles(CustomEnums.ProfileGender gender)
        //{
        //    if (gender == CustomEnums.ProfileGender.Male)
        //    {
        //        //get details of female
        //        return GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Female).Take(10);
        //    }
        //    else if (gender == CustomEnums.ProfileGender.Female)
        //    {
        //        //get details of males
        //        return GetAllProfiles().Where(x => x.Gender == CustomEnums.ProfileGender.Male).Take(10);
        //    }
        //    return GetAllProfiles().Take(10);
        //}

        public Profile GetProfileById(string profileId)
        {
            return context.Profiles.FirstOrDefault(x => x.ProfileId == profileId);
        }

        public Profile GetProfileByUserId(string userId)
        {
            return context.Profiles.FirstOrDefault(x => x.UserId == userId);
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
