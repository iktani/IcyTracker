using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcyTracker.Models
{
    public enum GoalType
    {
        OneX,
        TwoX
    }

    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public GoalType Goal { get; set; }

        public StravaInfoModel StravaInfo { get; set; }

        public IList<WorkoutModel> Workouts { get; set; }
    }
}
