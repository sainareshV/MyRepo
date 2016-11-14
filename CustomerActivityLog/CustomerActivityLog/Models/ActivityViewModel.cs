using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CustomerActivityLog.Models;

namespace CustomerActivityLog.Models
{
    public class ActivityViewModel
    {
        public FieldActivityLog fields { get; set; }
        public BlockActivityLog blocks { get; set; }

        //public string UniqueID { get; set; }
        //public string FieldName { get; set; }
        //public string FieldValue { get; set; }
        //public short? BlockType { get; set; }
        //public string BlockName { get; set; }
    }
}