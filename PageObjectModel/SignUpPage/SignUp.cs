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
        By Sin = By.LinkText("Sign In");
        //varify 'New Customers' is visible
        By register = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[2]/div[2]/div/div/a/span");
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
        By company = By.Id("company");
        By street = By.Id("street_1");
        By city = By.Name("city");
        By phone = By.Name("telephone");
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
        By hompagevisibility = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/a/span/span[1]");


        //operational methods
        public void ClickSignUpLink()
        {           
            Find_Elements_and_Validate(Sin);
            clickItems(Sin);
            //Verify that home page is visible successfully
            GetElementText_And_Verify_Visibilit("New Luma Yoga Collection", hompagevisibility);
            //varify 'New Customers' is visible
            GetElementText_And_Verify_Visibilit("New Customers", register);
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
        public void ClickCreateA()
        {
            //validate textbox
            Find_Elements_and_Validate(createaccount);
            //set texts into text box
            WaitforElement(createaccount);
            clickItems(createaccount);
            //Verify that Account is created visible successfully
            GetElementText_And_Verify_Visibilit("My Account",ele);
            //Verify 'New User Signup!' is visible
            GetElementText_And_Verify_Visibilit("Welcome, saad umar!", element);
        }
        public void AddressBook()
        {
            Find_Elements_and_Validate(addressbook);
            clickItems(addressbook);
            SetTextIntoTextBox("Contour Software house pvt ltd.",company);
            SetTextIntoTextBox("03086065776",phone);
            SetTextIntoTextBox("PO 765,California",street);
            SetTextIntoTextBox("New York",city);
            SelectDropDownItems(dropDownlist);
            SetTextIntoTextBox("76566", zip);
            SelectDropDownItems(country);
            clickItems(saveaddress);
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
        public void signup(string fname, string lname, string mail, string pass, string cpass)
        {
            this.ClickSignUpLink();
            this.SetFirstName(fname);
            this.SetlastName(lname);
            this.CheckBox();
            this.SetMail(mail);
            this.SetPassword(pass);
            this.ConfirmPassword(cpass);
            this.ClickCreateA();
            AddressBook();
      //      EditAccountInfo();
            SignOut();

        }
    }

}
