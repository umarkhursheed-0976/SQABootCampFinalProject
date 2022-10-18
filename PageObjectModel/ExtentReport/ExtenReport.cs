using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System.IO;
using OpenQA.Selenium;
using System.Xml.Linq;
using AventStack.ExtentReports.Core;

namespace SQABootCampFinalProject.PageObjectModel.ExtentClass
{
    [TestClass]
    public class ExtenReport
    {
        public static ExtentReports extentReport;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;
        public TestContext TestContext { get; set; }
        public static IWebDriver driver;
        //public ExtenReport(string path, bool f)
        //{
        //    string extentreportPath = path;
        //    f = false;
        //}
        public static void LogReport(string testcase)
        {
            extentReport = new ExtentReports();
            dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;
           // ExtenReport obj = new ExtenReport(dirpath, false);
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extentReport.AttachReporter(htmlReporter);
            



            //
            //extentReport = new ExtentReports();
            //var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("/bin/Debug", "");
            //DirectoryInfo di = Directory.CreateDirectory(dir + "//TestExecutionReports");
            //var htmlReporter = new ExtentHtmlReporter(dir + "//TestExecutionReports" + "//Automation_Report" + ".html");
            //extentReport.AttachReporter(htmlReporter);
        }


    }
}
