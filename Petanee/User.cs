using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petanee
{
    class User
    {
        public int userID;
        public string username { get; set; }
        public string password { get; set; }
        public string userLocation;
        public string locationClimate;

        public Boolean login(string username, string password)
        {
            return true;
        }
        public String getClimate(string userLocation)
        {
            return locationClimate;
        }
    }
}
