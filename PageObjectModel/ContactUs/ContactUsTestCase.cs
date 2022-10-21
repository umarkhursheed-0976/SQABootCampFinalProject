using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.Browser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABootCampFinalProject.PageObjectModel.ContactUs

{
    [TestClass]
    public class ContactUsTestCase : CommonMethodClass
    {
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\ContactUs\\ContactForm.csv", "ContactForm#csv", DataAccessMethod.Sequential)]
        public void Verfy_Contact_Us_Form_By_Fill_All_MandatoryFields()
        {
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("ContactUs");
            string name = TestContext.DataRow[0].ToString();
            string mail = TestContext.DataRow[1].ToString();
            string Contact = TestContext.DataRow[2].ToString();
            string message = TestContext.DataRow[3].ToString();
            ContactUsClass obj = new ContactUsClass();
            obj.Contact_Us(name, mail, Contact, message);
            

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\ContactUs\\ContactForm.xml", "user", DataAccessMethod.Sequential)]
        public void Verfy_Contact_Us_Form_By_Empty_All_MandatoryFields()
        {
            BrowserClass.SetUpApplication("FireFox");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("ContactUs");
        
            string name = TestContext.DataRow["name"].ToString();
            string mail = TestContext.DataRow["email"].ToString();
            string Contact = TestContext.DataRow["phone"].ToString();
            string message = TestContext.DataRow["message"].ToString();
            ContactUsClass obj = new ContactUsClass();
            obj.Contact_Us(name, mail, Contact, message);
             

        }



    }
}

