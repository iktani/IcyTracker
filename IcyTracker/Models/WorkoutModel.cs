using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcyTracker.Models
{
    public enum SwimMeasurementType
    {
        Yards,
        Meters,
        Miles
    }

    public class WorkoutModel
    {
        public int ID { get; set; }
        public double Swim { get; set; }
        public SwimMeasurementType Metric { get; set; }
        public double Bike { get; set; }
        public double Run { get; set; }
        public DateTime Date { get; set; }

        public int UserID { get; set; }
        public UserModel User { get; set; }
    }
}
