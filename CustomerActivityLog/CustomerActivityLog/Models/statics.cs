using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerActivityLog.Models
{
    public enum AccountCreation 
    {
        Email,
        ConfirmEmail,
        PhoneNumber,
        Password,
        ConfirmPassword,
        DOB,
        FirstName,
        LastName,
        SSN,
        SecurityQuestion,
        SecurityAnswer,
        ConsentReportAgreed,
        IsActiveMilitary
    }
}