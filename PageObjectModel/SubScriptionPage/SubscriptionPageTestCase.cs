using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.SubScriptionPage
{
    [TestClass]
    public class SubscriptionPageTestCase:CommonMethodClass
    {
        [TestMethod, TestCategory("Subscription")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SubScriptionPage\\Subscription.xml", "validEmail", DataAccessMethod.Sequential)]
        //valid eamil
        public void Subscription_With_Valid_Email_Homepage()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            string email = TestContext.DataRow["Email"].ToString();
            Subscriptionpage obj = new Subscriptionpage();
            obj.Subscription1(email);
            Sleep(2);
            Close();
        }
        //invalid email format
        [TestMethod, TestCategory("Subscription")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SubScriptionPage\\Subscription.xml", "InvalidEmail", DataAccessMethod.Sequential)]
        public void Subscription_With_InValid_Email_HomePage()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            string email = TestContext.DataRow["Email"].ToString();
            Subscriptionpage obj = new Subscriptionpage();
            obj.Subscription2(email);
            Sleep(2);
            Close();
        }

    }
}
