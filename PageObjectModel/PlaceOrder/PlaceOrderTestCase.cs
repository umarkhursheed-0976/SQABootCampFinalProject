using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABOOTCAUMP01_FINAL_PROJECT;
using SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel;
using SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.NewFolder1
{
    [TestClass]
    public class PlaceOrderTestCase : CommonMethodClass
    {
       
        [TestMethod]
        public void PlaceOrder_SignIn_While_CheckOut()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("ContactUs");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.PlaceOrder1();
        }
    
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABOOTCAUMP01_FINAL_PROJECT(Umar_Khursheed)\\SQABOOTCAUMP01_FINAL_PROJECT(Umar_Khursheed)\\signup.xml", "signupWhileAddToWishlist", DataAccessMethod.Sequential)]
        public void PlaceOrder_Register_While_Add_Item_Ito_Wishlist()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
            SetUpApplication();
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            CommonMethodClass.driver.Url = url;
            CommonClass obj = new CommonClass();
            obj.PlaceOrder2(fname, lname, email, pass, confirmp);

        }
        [TestMethod] // TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABOOTCAUMP01_FINAL_PROJECT(Umar_Khursheed)\\SQABOOTCAUMP01_FINAL_PROJECT(Umar_Khursheed)\\signup.xml", "RegisterBeforeCheckOut", DataAccessMethod.Sequential)]
        public void PlaceOrder_Register_Before_Checkout()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("PlaceOrder");
            SetUpApplication();
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            CommonMethodClass.driver.Url = url;
            CommonClass obj = new CommonClass();
            obj.PlaceOrder3(fname, lname, email, pass, confirmp);

        }

    }
}
