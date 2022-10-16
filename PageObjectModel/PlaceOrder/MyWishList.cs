using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class MyWishList:CommonMethodClass
    {
        By mywishlist = By.XPath("/html/body/div[2]/main/div[2]/div[1]/div[1]/h1/span");
        public void My_Wish_List_Visible()
        {
            //verify 'My Wish List' is visible
            GetElementText_And_Verify_Visibilit("My Wish List", mywishlist);
        }

    }
}
