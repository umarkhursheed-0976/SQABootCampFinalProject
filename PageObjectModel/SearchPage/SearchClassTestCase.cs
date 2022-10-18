using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_
{
    [TestClass]
    public class SearchClassTestCase:CommonMethodClass
    {
        [TestMethod, TestCategory("SearchClass")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SearchPage\\SearchData.xml", "ValidData", DataAccessMethod.Sequential)]
        public void search_and_Select_Items_From_Suggestion()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("search");
            SetUpApplication();
            string item1 = TestContext.DataRow["data1"].ToString();
            log.Info("Enter data1 to search");
            string item2 = TestContext.DataRow["data2"].ToString();
            log.Info("Enter data2 to search");
            string item3 = TestContext.DataRow["data3"].ToString();
            log.Info("Enter data3 to search");
            SearchClass obj = new SearchClass();
            log.Info("SearchClass object created successfully");
          obj.Suggestion_Items(item1,item2,item3);
            log.Info("Application is working");
            log.Info("Calle to search class method");
            Sleep(2);
            Close();
        }

        [TestMethod, TestCategory("SearchClass")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SearchPage\\SearchData.xml", "InvalidData", DataAccessMethod.Sequential)]
        public void Search_Products_By_Invalid_Data()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("search");
            SetUpApplication();
            string item1 = TestContext.DataRow["data1"].ToString();
            log.Info("Enter data1 to search");
            string item2 = TestContext.DataRow["data2"].ToString();
            log.Info("Enter data2 to search");
            string item3 = TestContext.DataRow["data3"].ToString();
            log.Info("Enter data3 to search");
            SearchClass obj = new SearchClass();
            log.Info("SearchClass object created successfully");
            obj.Search_With_InvalidData(item1, item2, item3);
            log.Info("Application is working");
            log.Info("Calle to search class method");
            Sleep(2);
            Close();
        }
    }
}
