using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABootCampFinalProject.PageObjectModel.ContactUs

{
    [TestClass]
    public class ContactUsClass : CommonMethodClass
    {
        By name = By.Name("q3_name");
        By email = By.Id("input_4");
        By contactno = By.Id("input_5");
        By message = By.Id("input_6");
        By submitform = By.Id("input_7");
        By contactus = By.XPath("/html/body/div[2]/footer/div/div[2]/div/ul/li[3]/a");
        By contactusform = By.Id("header_8");

        public void Contact_Us(string Name, string Email, string Contactno, string Message)
        {

            //Verify that home page is visible successfully
            GetElementText_And_Verify_Visibilit("New Luma Yoga Collection", hompagevisibility);
            //scroll to bottom
            Scroll_To_Element(contactus);
            //verify elements enable and displayed
            Find_Elements_and_Validate(contactus);
            //click onto element
            clickItems(contactus);
            driver.SwitchTo().Frame("222202192597454");
            //verify 'contact us' visibility
            GetElementText_And_Verify_Visibilit("Contact Us", contactusform);
            SetTextIntoTextBox(Name, name);
            SetTextIntoTextBox(Email, email);
            SetTextIntoTextBox(Contactno, contactno);
            SetTextIntoTextBox(Message, message);
            Sleep(15);
            Find_Elements_and_Validate(submitform);
            clickItems(submitform);
            driver.SwitchTo().DefaultContent();
        }

    }
}
