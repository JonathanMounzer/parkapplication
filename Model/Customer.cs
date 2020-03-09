using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkApplication
{
    class Customer
    {
        public string pnr { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string account { get; set; }
        public string password { get; set; }
    }
    public static class Constants
    {
        public static string UserId { get; set; }
    }
}
