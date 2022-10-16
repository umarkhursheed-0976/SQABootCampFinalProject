 using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SQABootCampFinalProject.PageObjectModel.BaseClass;

namespace SQABootCampFinalProject.PageObjectModel.LogInPage

{
    [TestClass]
    public class LoginPageTestCase : CommonMethodClass 
    {
        [TestMethod, TestCategory("LogIn")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\LogInPage\\LogIn.xml", "LoginWithValidcredentials", DataAccessMethod.Sequential)]

        public void LoginWithValidcredentials()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            CommonMethodClass.driver.Url = url;
            LogIn obj = new LogIn();
            obj.LogIn_Valid(email, pass);
            Close();                

        }
        [TestMethod, TestCategory("LogIn")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\LogInPage\\LogIn.csv", "LoginWithInValidcredentials", DataAccessMethod.Sequential)]
        public void LoginWithInvalidCredentials()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            string url = TestContext.DataRow["url"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            CommonMethodClass.driver.Url = url;
            LogIn obj = new LogIn();
            obj.LogIn_Invalid(email, pass);
            Close();
        }
        [TestMethod, TestCategory("LogIn")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "Login.csv", "Login#csv", DataAccessMethod.Sequential)]

        public void LogOut()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            string url = TestContext.DataRow[0].ToString();
            string email = TestContext.DataRow[1].ToString();
            string pass = TestContext.DataRow[2].ToString();
            CommonMethodClass.driver.Url = url;
            LogIn obj = new LogIn();
            obj.SignOut(email, pass);
            Close();
        }

    }
}

