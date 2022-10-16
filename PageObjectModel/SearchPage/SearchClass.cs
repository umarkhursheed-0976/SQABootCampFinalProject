using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_
{
    [TestClass]
    public class SearchClass:CommonMethodClass
    {
        By search = By.Id("search");
       By finditem = By.Id("qs-option-1");
        By clickbtn = By.XPath("//button[@ class='action search']");
        By item1 = By.XPath("/html/body/div[2]/header/div[2]/div[2]/div[2]/form/div[1]/div/div[1]/ul/li[2]/span[1]");
        By item2 = By.XPath("/html/body/div[2]/header/div[2]/div[2]/div[2]/form/div[1]/div/div[1]/ul/li[2]/span[1]");
        By item3 = By.XPath("/html/body/div[2]/header/div[2]/div[2]/div[2]/form/div[1]/div/div[1]/ul/li[1]/span[1]");
        By hompagevisibility = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/a/span/span[1]");
        By searchitem1 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/div/strong/a");
        By relevantitems = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/dl/dt");
        By searchitem2 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[2]/div/div/strong/a");
        By searchitem3 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/div/strong/a");


        public void Search_Item1(string text)
        {
            //Verify that home page is visible successfully
            GetElementText_And_Verify_Visibilit("New Luma Yoga Collection", hompagevisibility);
            IWebElement ele = driver.FindElement(search);
            SetTextIntoTextBox(text, search);
            Sleep(2);
            ele.SendKeys(Keys.Space);
            Sleep(3);
            clickItems(item1);
            Implicitwait(5);
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Hero Hoodie", searchitem1);
            // Verify all the products related to search are visible
             GetElementText_And_Verify_Visibilit("Related search terms", relevantitems);
            Clear(search);
        }
        
        //search item2
        public void Search_Item2(string text)
        {
            IWebElement ele = driver.FindElement(search);
            SetTextIntoTextBox(text, search);
            Sleep(2);
            ele.SendKeys(Keys.Space);
            Sleep(3);
            clickItems(item2);
            Implicitwait(5);
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Sinbad Fitness Tank", searchitem2);
            //Verify all the products related to search are visible
            GetElementText_And_Verify_Visibilit("Related search terms", relevantitems);
            Clear(search);
        }
        //item3
        public void Search_Item3(string text)
        {
            IWebElement ele = driver.FindElement(search);
            SetTextIntoTextBox(text, search);
            Sleep(2);
            ele.SendKeys(Keys.Space);
            Sleep(3);
            clickItems(item3);
            Implicitwait(5);
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Breathe-Easy Tank", searchitem3);
            // Verify all the products related to search are visible
            GetElementText_And_Verify_Visibilit("Related search terms", relevantitems);
            Clear(search);
        }

       
        public void Click_search_Button()
        {
            Perform_Action(clickbtn);
            clickItems(clickbtn);
        
        }
        public void Clear_text()
        {
            Clear(search);
        }
        public void Suggestion_Items(string text1,string text2,string text3)
        {
            Search_Item1(text1);
            Sleep(2);
            Search_Item2(text2);
            Sleep(2);
            Search_Item3(text3);
        }
    }

}
