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
        By searchitem1 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/div/strong/a");
        By relevantitems = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/dl/dt");
        By searchitem2 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[2]/div/div/strong/a");
        By searchitem3 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[2]/ol/li[1]/div/div/strong/a");


      
        public void Verify_All_Products_Related_Search_Visible()
        {
            // Verify all the products related to search are visible
            GetElementText_And_Verify_Visibilit("Related search terms", relevantitems);
        }
        public void Verify_Search_Product_Hero_Hoodie_Showing()
        {
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Hero Hoodie", searchitem1);
        }
        public void Verify_Search_Product_Sinbad_Fitness_Showing()
        {
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Sinbad Fitness Tank", searchitem2);
        }
        public void Verify_Search_Breathe_Showing()
        {
            //Verify 'SEARCHED PRODUCTS' is visible
            GetElementText_And_Verify_Visibilit("Breathe-Easy Tank", searchitem3);
        }
        public void Clear_SearchB0x()
        {
            Implicitwait(5);
            Clear(search);
        }

        public void Search_Item1(string text)
        { 
            SetTextIntoTextBox(text, search);
            Sleep(2);
          Press_Space(search);
            Sleep(2);
            clickItems(item1);         
        }
        
        //search item2
        public void Search_Item2(string text)
        {
       
            SetTextIntoTextBox(text, search);
            Sleep(2);
                Press_Space(search);
            Sleep(2);
            clickItems(item2);
    
        }
        //item3
        public void Search_Item3(string text)
        {   
            SetTextIntoTextBox(text, search);
            Sleep(2);
           Press_Space(search);
       
            Sleep(2);
            clickItems(item3);
        }
   

       
        public void Click_search_Button()
        {
            Perform_Action(clickbtn);
            clickItems(clickbtn);
        
        }
        
        public void Suggestion_Items(string text1,string text2,string text3)
        {
            //Verify that home page is visible successfully
            Verify_HomePage_Visible();
            Search_Item1(text1);
            Verify_Search_Product_Hero_Hoodie_Showing();
            Verify_All_Products_Related_Search_Visible();
            Clear_SearchB0x();
            Sleep(2);
            Search_Item2(text2);
            Verify_Search_Product_Sinbad_Fitness_Showing();
            Verify_All_Products_Related_Search_Visible();
            Clear_SearchB0x();
            Sleep(2);
            Search_Item3(text3);
            Verify_Search_Breathe_Showing();
            Verify_All_Products_Related_Search_Visible();
            Clear_SearchB0x();
        }
        public void Search_With_InvalidData(string text1, string text2, string text3)
        {
            //Verify that home page is visible successfully
            Verify_HomePage_Visible();
            Search_Item1(text1);
            Click_search_Button();
            Clear_SearchB0x();
            
            Search_Item2(text2);
            Click_search_Button();
            Clear_SearchB0x();
       
            Search_Item3(text3);
            Click_search_Button();
            Clear_SearchB0x();

        }
        
    }

}
