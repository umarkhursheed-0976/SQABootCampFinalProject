using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class ShippingAddress:CommonMethodClass
    {

        By shippingaddress = By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[1]/div[1]");
        By next = By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[2]/div/div[3]/form/div[3]/div/button/span");
        //SignIn while shipping
        By signinn = By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[1]/button/span");
        By logineamil = By.Id("login-email");
        By loginpassword = By.Id("login-password");
        By clicktosignin = By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[1]/aside/div[2]/div/div/div/div[3]/form/div[2]/div[1]/button/span");
        By movenext = By.XPath("/html/body/div[2]/main/div[2]/div/div[2]/div[4]/ol/li[2]/div/div[3]/form/div[3]/div/button/span");
     

        //SignIn while shipping

       
        // verify 'Shipping Address' is visible
        public void Shipping_Address_Visible()
        {
            Sleep(5);
            //verify 'Shipping Address' is visible
            GetElementText_And_Verify_Visibilit("Shipping Address", shippingaddress);
        }
        public void SignInWhileShipping()
        {
            Shipping_Address_Visible();
            clickItems(signinn);
            Sleep(3);
            SetTextIntoTextBox("saadumar87649023165627634766776@gmail.com", logineamil);
            SetTextIntoTextBox("Jutt12345678@", loginpassword);
            clickItems(clicktosignin);
            Implicitwait(15);
            clickItems(movenext);
            Sleep(3);
        }
        public void Company()
        {
          
            Find_Elements_and_Validate(company);
            SetTextIntoTextBox("Contour Software house pvt, Lahore", company);
        }
        public void Street()
        {
            Find_Elements_and_Validate(street);
            SetTextIntoTextBox("Po KH 7676,California", street);
        }
        public void City()
        {
            Find_Elements_and_Validate(city);
            SetTextIntoTextBox("California", city);

        }
        public void Phone_No()
        {
            Find_Elements_and_Validate(phone);
            SetTextIntoTextBox("+923086065776", phone);
        }
        
        
        public void Move_Next()
        {
            Find_Elements_and_Validate(next);
            clickItems(next);
        }
       
        public void Shipping_Address_Ingrid()
        {
            Shipping_Address_Visible();
            Company();
            City();
            Street();
            City();
            Phone_No();
            Move_Next();
        }
       
    }
}
