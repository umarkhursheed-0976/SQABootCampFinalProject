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
        public void SignUp_with_invalid_credentials()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
            CommonMethodClass.SetUpApplication();
            string url = TestContext.DataRow["url"].ToString();
            string fname = TestContext.DataRow["fname"].ToString();
            String lname = TestContext.DataRow["lname"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string confirmp = TestContext.DataRow["confirmp"].ToString();
            CommonMethodClass.driver.Url = url;
            SignUp obj = new SignUp();
            obj.Invalidsignup(fname, lname, email, pass, confirmp);
            Sleep(3);
            Close();
        }
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "SignUp_with_valid_credentials", DataAccessMethod.Sequential)]
        public void Sign_up_with_Existing_User()
        { 
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
            CommonMethodClass.SetUpApplication();
                string url = TestContext.DataRow["url"].ToString();
                string fname = TestContext.DataRow["fname"].ToString();
                String lname = TestContext.DataRow["lname"].ToString();
                string email = TestContext.DataRow["email"].ToString();
                string pass = TestContext.DataRow["password"].ToString();
                string confirmp = TestContext.DataRow["confirmp"].ToString();
                CommonMethodClass.driver.Url = url;
                SignUp obj = new SignUp();
                obj.SignUp_With_Existing_User(fname, lname, email, pass, confirmp);
            Sleep(3);
            Close();

        }
        //Sign up with valid credentia;s. Assert welcome screen
        [TestMethod]// TestCategory("SignUp")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SignUpPage\\signup.xml", "Sign_up_new_user_with_valid_Credentials", DataAccessMethod.Sequential)]
        public void Sign_up_new_user_with_valid_Credentials()
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
                SignUp obj = new SignUp();
            obj.SignUp_With_new_User(fname, lname, email, pass, confirmp);
            Close();

        }
        [TestMethod]//TestCategory("SignUp")]
        public void Click_Sign_Up_button_WithOut_Enter_AnyData()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SignUp");
            SetUpApplication();
                SignUp obj = new SignUp();
            obj.Click_SignUp_without_Empty_Fields();
            Close();

        }
    }
}

