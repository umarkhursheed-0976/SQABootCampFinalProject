using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT.PageObjectModel
{
    [TestClass]
    public class SignUp : CommonMethodClass
    {
        


        //all webpage elements 
        
        By Sup = By.LinkText("Create an Account");
        By firstname = By.Id("firstname");
        By lastname = By.Id("lastname");
        By checkbox = By.Id("is_subscribed");
        By email = By.Id("email_address");
        By password = By.Id("password");
        By Confirmpassword = By.Id("password-confirmation");
        By createaccount = By.XPath("/html/body/div[2]/main/div[3]/div/form/div/div[1]/button/span");
        //Save Address Book information
        By addressbook = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div[2]/ul/li[6]/a");
        By dropDownlist = By.Id("region_id");
        By zip = By.Id("zip");
        By country = By.Id("zip");
        By saveaddress = By.XPath("//button[@class='action save primary']");
        //validate user sign in
        By element = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[1]/span");
        By ele = By.XPath("//span[@data-ui-id='page-title-wrapper']");
        //Edit account information
        By accountinfo = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div[2]/ul/li[7]/a");
        By changeeamil = By.Id("change-email");
        By changepassword = By.Id("change-password");
        By mail = By.Id("email");
        By currentpass = By.Id("current-password");
        By saveinfo = By.XPath("/html/body/div[2]/main/div[2]/div[1]/form/div/div[1]/button/span");
        By signout = By.XPath("//button[@data-action='customer-menu-toggle']");
        By clicksignout = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[2]/div/ul/li[3]/a");
        By createCustomerAccountVisible = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By signInAsUserVisible = By.XPath("/html/body/div[2]/header/div[1]/div/ul/li[1]/span");
        //
        //varify 'New Customers' is visible

        By isNewCustomerShowing = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[2]/div[1]/strong");

       
        //operational methods
        public void ClickSignUpLink()
        {           
            Find_Elements_and_Validate(signin);
            clickItems(signin);
        }
        public void Verify_New_Customer_Visible()
        {
            //implicit wait
            Implicitwait(10);
            //varify 'New Customers' is visible
            GetElementText_And_Verify_Visibilit("New Customers", isNewCustomerShowing);
        }
        public void Click_CreateAn_Account()
        {
            Find_Elements_and_Validate(Sup);
            clickItems(Sup);
        }
        public void SetFirstName(string fname)
        {
            //validate textbox
            Find_Elements_and_Validate(firstname);
         //  GetElementText_And_Verify_Visibilit(firstname);
            //set texts into text box
            SetTextIntoTextBox(fname, firstname);
        }
        public void SetlastName(string lname)
        {
            //validate textbox
            Find_Elements_and_Validate(lastname);
            //set texts into text box
            SetTextIntoTextBox(lname, lastname);
        }
        public void CheckBox()
        {
            check_CheckBox(checkbox);
        }
        public void SetMail(string mail)
        {

            //validate textbox
            Find_Elements_and_Validate(email);
            GetElementstate(email);
          //  GetElementText(email);
            //set texts into text box
            SetTextIntoTextBox(mail, email);

        }
        public void SetPassword(string pas)
        {
            isElementTextField(password);
            GetElementstate(password);
       //     GetElementText(password);
            //set texts into text box
            SetTextIntoTextBox(pas, password);
        }
        public void ConfirmPassword(string cpas)
        {
            //validate textbox
            Find_Elements_and_Validate(Confirmpassword);
            //set texts into text box
            SetTextIntoTextBox(cpas, Confirmpassword);
        }
        public void ClickCreateAccount()
        {
            //validate textbox
            Find_Elements_and_Validate(createaccount);
            //set texts into text box
            WaitforElement(createaccount);
            clickItems(createaccount);
            Sleep(5);

        }
        public void Verify_Account_Created()
        {
            //Verify that Account is created visible successfully
            GetElementText_And_Verify_Visibilit("My Account", ele);
        }
        public void Verify_SignIn_As_New_User_Visible()
        {
            //Verify that 'Logged in as username' is visible
            GetElementText_And_Verify_Visibilit("Welcome, Saad Umar!", signInAsUserVisible);
        }
        public void Verify_Create_Custome_Account_Visible()
        {
            //verify 'Create New Customer Account' is visible
            GetElementText_And_Verify_Visibilit("Create New Customer Account", createCustomerAccountVisible);
        }
     
       
        //public void EditAccountInfo()
        //{
        //    Find_Elements_and_Validate(accountinfo);
        //    clickItems(accountinfo);
        //    Clear(firstname);
        //    SetTextIntoTextBox("saad", firstname);
        //    Clear(lastname);
        //    SetTextIntoTextBox("umar", lastname);
        //    check_CheckBox(changeeamil);
        //    Sleep(2);
        //    check_CheckBox(changepassword);
        //    Sleep(2);
        //    Clear(mail);
        //    SetTextIntoTextBox("jutt@gmail.com", mail);
        //    SetTextIntoTextBox("Jutt12345678@", currentpass);
        //    SetTextIntoTextBox("Jutt12345678@", password);
        //    SetTextIntoTextBox("Jutt12345678@", Confirmpassword);
        //    clickItems(saveinfo);   

        //}
        public void SignOut()
        {
            clickItems(signout);
            Sleep(2);
            Find_Elements_and_Validate(clicksignout);
            clickItems(clicksignout);
            Sleep(7);
            GetElementText_And_Verify_Visibilit("Default welcome msg!", element);
        }
        public void Invalidsignup(string fname, string lname, string mail, string pass, string cpass)
        {
            //Verify that home page is visible successfully
            Verify_HomePage_Visible();
            ClickSignUpLink();
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            Verify_Create_Custome_Account_Visible();
            SetFirstName(fname);
            SetlastName(lname);
            CheckBox();
            SetMail(mail);
            SetPassword(pass);
            ConfirmPassword(cpass);
            ClickCreateAccount();
            Sleep(7);
            TakeScreenShot(Status.Pass, "Error message showing");


        }
        public void SignUp_With_Existing_User(string fname, string lname, string mail, string pass, string cpass)
        {
            Verify_HomePage_Visible();
            ClickSignUpLink();
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            Verify_Create_Custome_Account_Visible();
            SetFirstName(fname);
            SetlastName(lname);
            CheckBox();
            SetMail(mail);
            SetPassword(pass);
            ConfirmPassword(cpass);
            ClickCreateAccount();
            Sleep(5);

            TakeScreenShot(Status.Pass, "Error message showing");

        }
        public void SignUp_With_new_User(string fname, string lname, string mail, string pass, string cpass)
        {
            Verify_HomePage_Visible();
            ClickSignUpLink();
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            Verify_Create_Custome_Account_Visible();
            SetFirstName(fname);
            SetlastName(lname);
            CheckBox();
            SetMail(mail);
            SetPassword(pass);
            ConfirmPassword(cpass);
            ClickCreateAccount();
            Verify_Account_Created();
            Verify_SignIn_As_New_User_Visible();
            SignOut();
            Sleep(4);

            TakeScreenShot(Status.Pass, "Homepage showing");


        }
        public void Click_SignUp_with_Empty_Fields()
        {
            Verify_HomePage_Visible();
            ClickSignUpLink();
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            ClickCreateAccount();
            Sleep(5);
            TakeScreenShot(Status.Pass, "Error message showing");

        }

        public void SignUp_While_Addto_WishList(string fname, string lname, string mail, string pass, string cpass)
        {
        
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            Verify_Create_Custome_Account_Visible();
            SetFirstName(fname);
            SetlastName(lname);
            CheckBox();
            SetMail(mail);
            SetPassword(pass);
            ConfirmPassword(cpass);
            ClickCreateAccount();
        }
        public void SignUp_Before_CheckOut(string fname, string lname, string mail, string pass, string cpass)
        {
            Verify_HomePage_Visible();
            ClickSignUpLink();
            Verify_New_Customer_Visible();
            Click_CreateAn_Account();
            Verify_Create_Custome_Account_Visible();
            SetFirstName(fname);
            SetlastName(lname);
            CheckBox();
            SetMail(mail);
            SetPassword(pass);
            ConfirmPassword(cpass);
            ClickCreateAccount();
            Verify_Account_Created();
            Verify_SignIn_As_New_User_Visible();

        }
    }

}
