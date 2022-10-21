using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.Browser;


namespace SQABOOTCAUMP01_FINAL_PROJECT
{
    [TestClass]
    public class SignUpClassTestCases : CommonMethodClass
    {
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        base.TestContext = value;
        //        testContextInstance = value;
        //    }
        //}

        //private TestContext testContextInstance;



        [TestMethod]//TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "SignUp_with_invalid_credentials", DataAccessMethod.Sequential)]
        public void Verify_SignUp_with_invalid_credentials()
        {
            BrowserClass.SetUpApplication("FireFox");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
        
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            BrowserClass.driver.Url = url;
            SignUp obj = new SignUp();
            obj.Invalidsignup(fname, lname, email, pass, confirmp);
        
        }
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "SignUp_with_valid_credentials", DataAccessMethod.Sequential)]
        public void Verify_Sign_up_with_Existing_User()
        {
            BrowserClass.SetUpApplication("Edge");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
                string url = TestContext.DataRow["url"].ToString();
                string fname = TestContext.DataRow["fname"].ToString();
                String lname = TestContext.DataRow["lname"].ToString();
                string email = TestContext.DataRow["email"].ToString();
                string pass = TestContext.DataRow["password"].ToString();
                string confirmp = TestContext.DataRow["confirmp"].ToString();
            BrowserClass.driver.Url = url;
                SignUp obj = new SignUp();
                obj.SignUp_With_Existing_User(fname, lname, email, pass, confirmp);
           

        }
        //Sign up with valid credentia;s. Assert welcome screen
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "Sign_up_new_user_with_valid_Credentials", DataAccessMethod.Sequential)]
        public void Verify_Sign_up_new_user_with_valid_Credentials()
        {
            BrowserClass.SetUpApplication("Edge");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
                string url = TestContext.DataRow["url"].ToString();
                string fname = TestContext.DataRow["fname"].ToString();
                String lname = TestContext.DataRow["lname"].ToString();
                string email = TestContext.DataRow["email"].ToString();
                string pass = TestContext.DataRow["password"].ToString();
                string confirmp = TestContext.DataRow["confirmp"].ToString();
            BrowserClass.driver.Url = url;
                SignUp obj = new SignUp();
            obj.SignUp_With_new_User(fname, lname, email, pass, confirmp);
            

        }
        [TestMethod]//TestCategory("SignUp")]
        public void Verify_Click_Sign_Up_button_WithOut_Enter_AnyData()
        {
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
                SignUp obj = new SignUp();
            obj.Click_SignUp_with_Empty_Fields();
            

        }
    }
}

