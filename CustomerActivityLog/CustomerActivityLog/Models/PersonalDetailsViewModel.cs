using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerActivityLog.Models
{
    public class PersonalDetailsViewModel
    {
        public class AddressDetails
        {
            public string AddressLine1 { get; set; }
            public string AddressLine2 { get; set; }
            public int CityID { get; set; }
            public long StateID { get; set; }
            public int ZipID { get; set; }
            public string IdentityNumber { get; set; }
            public int? LTIdentityTypeCodeID { get; set; }
            public int? PhotoIssuedStateID { get; set; }
        }
        public class EmploymentDetails
        {
            public int? LTSourceOfIncomeID { get; set; }
            public string EmployerName { get; set; }
            public string EmployerPhoneNumber { get; set; }
            public string EmployerAddressLine1 { get; set; }
            public string EmployerAddressLine2 { get; set; }
            //public int? CityID { get; set; }
            //public int? StateID { get; set; }
            //public int? ZipID { get; set; }
            public int LTPayFrequencyID { get; set; }
            public DateTime? PayDate { get; set; }
            public DateTime? SubsequentPayDateChecked { get; set; }
            public string DayOfWeek { get; set; }
            //public Weekdays DayOfWeek { get; set; }
            //public Weekdays DayOfWeek1 { get; set; }
            //public Weekdays DayOfWeek2 { get; set; }

            //public byte? DateOfMonth1 { get; set; }
            //public byte? DateOfMonth2 { get; set; }
            public string WeekOfMonth { get; set; }

            //public WeeksInMonth WeekOfMonth { get; set; }
            //public WeeksInMonth WeekOfMonth1 { get; set; }
            //public WeeksInMonth WeekOfMonth2 { get; set; }
            public decimal? GrossIncomeAmount { get; set; }
            public decimal? NetIncomeAmount { get; set; }
            public DateTime HireDate { get; set; }

        }
        public class IncomeDetails
        {
            public int AccountTypeID { get; set; }
            //public AccountType? AccountTypeID { get; set; }
            public string BankName { get; set; }
            public string ABANumber { get; set; }
            public string ConfirmABANumber { get; set; }
            public string AccountNumber { get; set; }
            public string ConfirmAccountNumber { get; set; }
            public bool? IsDirectDeposit { get; set; }
            public bool? AllowDecisionLogic { get; set; }
            public string CCLastFourDigits { get; set; }
            public string ConfirmCCLastFourDigits { get; set; }
            public string debitCardCVV { get; set; }
            public string NameOnTheDebitCard { get; set; }
            public string debitCardExpiryDt { get; set; }
        }
    }
}