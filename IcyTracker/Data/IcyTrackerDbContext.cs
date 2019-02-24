using IcyTracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcyTracker.Data
{
    public class IcyTrackerDbContext : DbContext
    {
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<StravaInfoModel> StravaInfoModels { get; set; }
        public DbSet<WorkoutModel> WorkoutModels { get; set; }

        public IcyTrackerDbContext(DbContextOptions<IcyTrackerDbContext> options) : base(options)
        {

        }
    }
}
