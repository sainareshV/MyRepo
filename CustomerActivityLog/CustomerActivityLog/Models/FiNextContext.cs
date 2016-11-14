using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerActivityLog.Models
{
    public class FiNextContext : DbContext
    {
        public FiNextContext()
            : base("name=FiNextContext")
        {
        }
    }
}