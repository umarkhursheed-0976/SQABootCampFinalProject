using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.DevTools;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.Browser;
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
        public void verify_search_with_ValidData_and_Select_Items_From_Suggestion()
        {
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SearchItems");
            string item1 = TestContext.DataRow["data1"].ToString();
            string item2 = TestContext.DataRow["data2"].ToString();
            string item3 = TestContext.DataRow["data3"].ToString();
            SearchClass obj = new SearchClass();
          obj.Suggestion_Items(item1,item2,item3);
         
        }

        [TestMethod, TestCategory("SearchClass")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\PageObjectModel\\SearchPage\\SearchData.xml", "InvalidData", DataAccessMethod.Sequential)]
        public void Search_Products_By_Invalid_Data()
        {
            BrowserClass.SetUpApplication("Edge");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("SearchItems");    
            string item1 = TestContext.DataRow["data1"].ToString();
            string item2 = TestContext.DataRow["data2"].ToString();
            string item3 = TestContext.DataRow["data3"].ToString();
            SearchClass obj = new SearchClass();
            obj.Search_With_InvalidData(item1, item2, item3);
        }
    }
}
