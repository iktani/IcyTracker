using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcyTracker.Models
{
    public class StravaInfoModel
    {
        public int ID { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int TokenExpiration { get; set; }
        public int AtheleteID { get; set; }

        public UserModel User { get; set; }
    }
}
