using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerActivityLog.Models
{
    public class AccVM
    {


        public Dictionary<string, object> Lists { get; set; }
        public Dictionary<string, object> Address { get; set; }
        public Dictionary<string, object> Employee { get; set; }
        public Dictionary<string, object> Income { get; set; }


        //public AccVM(string SessionID, string InsertedBy)
        //{
        //}
    }
}