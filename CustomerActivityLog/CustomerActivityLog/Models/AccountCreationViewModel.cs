using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerActivityLog.Models
{
    public class AccountCreationViewModel
    {
        public int SSN { get; set; }
        public string Email { get; set; }
        public string ConfirmEmail { get; set; }
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public bool? IsActiveMilitary { get; set; }
        public bool ConsentReportAgreed { get; set; }
    }
}