using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.HomePage
{

    //verify subscription in home page
    [TestClass]
    public class Subscriptionpage:CommonMethodClass
    {
        By newsletter = By.Id("newsletter");
        By cilckbtn = By.XPath("/html/body/div[2]/footer/div/div[1]/div[2]/form/div[2]/button/span");
        By ClicksubScribe = By.XPath("/html/body/div[2]/footer/div/div[1]/div[2]/form/div[2]/button/span");
        By message1 = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div/div");
        By message2 = By.XPath("/html/body/div[2]/footer/div/div[1]/div[2]/form/div[1]/div/label/div");

        public void Subscription1(string email)
        {
            //Verify that home page is visible successfully
            Verify_HomePage_Visible();
            //scroll to footer
            Scroll_To_Bottom();
            //Verify text 'SUBSCRIPTION'
            GetElementText_And_Verify_Visibilit("Subscribe", ClicksubScribe);
            SetTextIntoTextBox(email,newsletter);
            clickItems(cilckbtn);
            Sleep(3);
            // Verify success message 'Thank you for your subscription.' is visible
            GetElementText_And_Verify_Visibilit("Thank you for your subscription.", message1);
            Sleep(3);
            TakeScreenShot(Status.Pass, "Thank you for your subscription.");
        }
        public void Subscription2(string email)
        {
            //Verify that home page is visible successfully
            Verify_HomePage_Visible();
            //scroll to footer
            Scroll_To_Bottom();
            //Verify text 'SUBSCRIPTION'
            GetElementText_And_Verify_Visibilit("Subscribe", ClicksubScribe);
            SetTextIntoTextBox(email, newsletter);
            clickItems(cilckbtn);
            Sleep(4);
            // Verify success message 'Please enter a valid email address (Ex: johndoe@domain.com).' is visible
            GetElementText_And_Verify_Visibilit("Please enter a valid email address (Ex: johndoe@domain.com).", message2);
            Sleep(3);
            TakeScreenShot(Status.Pass, "Please enter a valid email address (Ex: johndoe@domain.com).");

        }

    }
}
