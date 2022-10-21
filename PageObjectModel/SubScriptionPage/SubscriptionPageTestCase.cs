using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.Browser;
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
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Subscription");
         
            string email = TestContext.DataRow["Email"].ToString();
            Subscriptionpage obj = new Subscriptionpage();
            obj.Subscription1(email);        
        }
        //invalid email format
        [TestMethod, TestCategory("Subscription")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SubScriptionPage\\Subscription.xml", "InvalidEmail", DataAccessMethod.Sequential)]
        public void Subscription_With_InValid_Email_HomePage()
        {
            BrowserClass.SetUpApplication("Edge");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Subscription");
            string email = TestContext.DataRow["Email"].ToString();
            Subscriptionpage obj = new Subscriptionpage();
            obj.Subscription2(email);
        
        }

    }
}
