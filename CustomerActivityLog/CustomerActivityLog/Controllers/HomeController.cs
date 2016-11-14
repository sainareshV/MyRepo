using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomerActivityLog.Models;
using System.Reflection;

namespace CustomerActivityLog.Controllers
{
    public class HomeController : Controller
    {
        CustomerEntity context = new CustomerEntity();
        public ActionResult Index()
        {
            return RedirectToAction("Customers");
        }
        [HttpGet]
        public ActionResult Customers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OnClick(ActivityViewModel log)
        {

            var strId = log.blocks.UniqueID;
            Session["Id"] = log.blocks.UniqueID;
            List<BlockActivityLog> av = new List<BlockActivityLog>();
            av = context.BlockActivityLogs.Where(x => x.BlockType == 0 && x.UniqueID == strId).OrderByDescending(x => x.InsertedDate).ToList();
           
            return View(av);
            
        }
        public ActionResult OnSubmit(ActivityViewModel field)
        {
            
            var str = Session["Id"];
            List<FieldActivityLog> fields = context.FieldActivityLogs.Where(x =>x.UniqueID == str).OrderByDescending(x => x.InsertedDate).ToList();
            return View(fields);
        }

        public ActionResult GetDetails(string InsertedBy, string BlockId,string SessionId)
        {
          
            string CustomerId = InsertedBy.Split(':')[1];
            AccVM Details = new AccVM();
            Session["SID"]=SessionId;
            var str = Session["SID"];
            var st = Session["id"];
            FieldActivityLog fieldLog = new FieldActivityLog();
            object FieldValue;
            List<FieldActivityLog> FieldActivityLst = context.FieldActivityLogs.Where(x => x.SessionID == SessionId).ToList();
            if (FieldActivityLst.Count > 0 && BlockId == "AccountCreation")
            {

                //Dictionary<string, object> AccountDetails = new Dictionary<string, object>();

                Dictionary<string, object> AccountDetails = new Dictionary<string, object>();
                foreach (PropertyInfo property in typeof(AccountCreationViewModel).GetProperties())
                {
                    FieldValue = FieldActivityLst.Where(x => x.FieldName == property.Name).Select(x => x.FieldValue).LastOrDefault();
                    //FieldValue = FieldActivityLst.Contains(property.Name);
                    if (FieldValue == null)
                        FieldValue = new object();
                    AccountDetails.Add(property.Name, FieldValue);
                }
           

                Details.Lists = AccountDetails;
            }
            else if (BlockId == "PersonalDetails")
            {
                Dictionary<string, object> personalDetails = new Dictionary<string, object>();

                foreach (PropertyInfo property in typeof(PersonalDetailsViewModel.AddressDetails).GetProperties())
                {

                    FieldValue = FieldActivityLst.Where(x => x.FieldName == property.Name).Select(x => x.FieldValue).LastOrDefault();
                    if (FieldValue == null)
                        FieldValue = new object();
                    personalDetails.Add(property.Name, FieldValue);

                }
                Details.Address = personalDetails;
                Dictionary<string, object> personalDetails1 = new Dictionary<string, object>();
                foreach (PropertyInfo property in typeof(PersonalDetailsViewModel.EmploymentDetails).GetProperties())
                {
                    //  Dictionary<string, object> personalDetails = new Dictionary<string, object>();
                    FieldValue = FieldActivityLst.Where(x => x.FieldName == property.Name).Select(x => x.FieldValue).LastOrDefault();
                    if (FieldValue == null)
                        FieldValue = new object();
                    personalDetails1.Add(property.Name, FieldValue);


                }
                Details.Employee = personalDetails1;
                Dictionary<string, object> personalDetails2 = new Dictionary<string, object>();
                foreach (PropertyInfo property in typeof(PersonalDetailsViewModel.IncomeDetails).GetProperties())
                {
                    // Dictionary<string, object> personalDetails = new Dictionary<string, object>();
                    FieldValue = FieldActivityLst.Where(x => x.FieldName == property.Name).Select(x => x.FieldValue).LastOrDefault();
                    if (FieldValue == null)
                        FieldValue = new object();
                    personalDetails2.Add(property.Name, FieldValue);

                }
                Details.Income = personalDetails2;
            }
            else if (BlockId == "DocumentDetails")
            {
                Dictionary<string, object> DocumentDetails = new Dictionary<string, object>();
                foreach (PropertyInfo property in typeof(DocumentViewModel).GetProperties())
                {
                    //FieldValue = FieldActivityLst.Where(x => x.FieldName == property.Name).Select(x => x.FieldValue).LastOrDefault();

                    FieldValue = from c in FieldActivityLst
                                 where c.FieldName.Contains("Mdl.Documents")
                                 select new
                                 {
                                     FieldValue = c.FieldValue
                                 };
                    if (FieldValue == null)
                        FieldValue = new object();
                    DocumentDetails.Add(property.Name, FieldValue);
                }
                Details.Lists = DocumentDetails;
            }
            else
            {

            }

            return View(Details);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}