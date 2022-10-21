using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABOOTCAUMP01_FINAL_PROJECT;
using SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel;
using SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home;
using SQABootCampFinalProject.PageObjectModel.Browser;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using OpenQA.Selenium.DevTools.V104.Browser;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.NewFolder1
{
    [TestClass]
    public class PlaceOrderTestCase : CommonMethodClass
    {
       
        [TestMethod]
        public void PlaceOrder_SignIn_While_CheckOut()
        {
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("PlaceOrder");
            CommonClass obj = new CommonClass();
            obj.PlaceOrder1();
            
           
        }
    
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "signupWhileAddToWishlist", DataAccessMethod.Sequential)]
        public void PlaceOrder_Register_While_Add_Item_Ito_Wishlist()
        {
            BrowserClass.SetUpApplication("Edge");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("PlaceOrder");
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            BrowserClass.driver.Url = url;
            CommonClass obj = new CommonClass();
            obj.PlaceOrder2(fname, lname, email, pass, confirmp);
         
            

        }
        [TestMethod] // TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "RegisterBeforeCheckOut", DataAccessMethod.Sequential)]
        public void PlaceOrder_Register_Before_Checkout()
        {
            BrowserClass.SetUpApplication("FireFox");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("PlaceOrder");
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            BrowserClass.driver.Url = url;
            CommonClass obj = new CommonClass();
            obj.PlaceOrder3(fname, lname, email, pass, confirmp);
           
        }

    }
}
