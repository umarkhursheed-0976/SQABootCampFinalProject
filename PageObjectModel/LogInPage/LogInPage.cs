using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.ExtentClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
namespace SQABootCampFinalProject.PageObjectModel.LogInPage

{
    [TestClass]
    public class LogIn : CommonMethodClass
    {
   
        //here by is a class
        By email = By.Id("email");
        By password = By.Id("pass");
        By submit = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/div[2]/form/fieldset/div[4]/div[1]/button/span");
      
        //logOut
        By signout = By.XPath("//button[@data-action='customer-menu-toggle']");
        By clicksignout = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[2]/div/ul/li[3]/a");
        //Verify/assert visibility
        By element = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[1]/span");
        By isCustomerLogInVisible = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By errormessage = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div/div");
        public void Verify_HomePage_Visible()
        {
            //Verify that home page is visible successfully
            GetElementText_And_Verify_Visibilit("New Luma Yoga Collection", hompagevisibility);
            Sleep(2);
        }
        //click to sign in button
        public void ClickSignInLink()
        {
            Implicitwait(10);
            Find_Elements_and_Validate(signin);
            clickItems(signin);
          
        }
        public void Verify_Customer_LogIn_Visible()
        {
            //Verify 'Customer Login ' is visible
            GetElementText_And_Verify_Visibilit("Customer Login", isCustomerLogInVisible);
            Sleep(2);
        }

        //set username in textBox
        public void SetUsername(string uname)
        {
            //validate text box
            Find_Elements_and_Validate(email);
            //set texts into text box
            Implicitwait(10);
            SetTextIntoTextBox(uname, email);
       
        }
        //setPassword in text Box
        public void SetpassWord(string pass)
        {
          
            //validate text box
            Find_Elements_and_Validate(password);
            Implicitwait(10);
            SetTextIntoTextBox(pass, password);
          
        }
        //click on login button for login
        public void ClickLogin()
        {
            
            Find_Elements_and_Validate(submit);
            Implicitwait(10);
            clickItems(submit);
        }
        public void Verify_SignIn_As_New_User_Visible()
        {
            //Verify that 'Logged in as username' is visible
            GetElementText_And_Verify_Visibilit("Welcome, Saad Umar!", element);
        }
        public void Verify_Error_Message_Showing_With_Invalid_credentials()
        {
            //verify error message showing or not
            GetElementText_And_Verify_Visibilit("The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later.", errormessage);
        } 
        public void Verify_Default_Msg_Visible()
        {
            //verify 'Default welcome msg!'is visible
            GetElementText_And_Verify_Visibilit("Default welcome msg!", element);
        }

        public void LogIn_Valid(string username, string password)
        {
            Verify_HomePage_Visible();
            ClickSignInLink();
            Verify_Customer_LogIn_Visible();
            SetUsername(username);
            SetpassWord(password);
            ClickLogin();
            Sleep(4);
            Verify_SignIn_As_New_User_Visible();
        }
        public void LogIn_Invalid(string username, string password)
        {
            Verify_HomePage_Visible();
            ClickSignInLink();
            Verify_Customer_LogIn_Visible();
            SetUsername(username);
            SetpassWord(password);
            ClickLogin();
            Sleep(4);
            Verify_Error_Message_Showing_With_Invalid_credentials();
        }
        public void SignOut(string username, string password)
        {
            Verify_HomePage_Visible();
            ClickSignInLink();
            Verify_Customer_LogIn_Visible();
            SetUsername(username);
            SetpassWord(password);
            ClickLogin();
            Sleep(4);
            clickItems(signout);
            Sleep(2);
            Find_Elements_and_Validate(clicksignout);
            clickItems(clicksignout);
            Sleep(7);
            Verify_Default_Msg_Visible();
        }
    }
}

