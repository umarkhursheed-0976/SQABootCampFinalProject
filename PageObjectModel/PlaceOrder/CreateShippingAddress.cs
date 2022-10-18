using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class CreateShippingAddress:CommonMethodClass
    {
        By createshippingaddress = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By street1 = By.Id("street_1");
        By selectstate = By.XPath("/html/body/div[2]/main/div[3]/div/form/fieldset[2]/div[3]/div/select");
     
        By zipcode = By.Id("zip");
        By country = By.XPath("/html/body/div[2]/main/div[3]/div/form/fieldset[2]/div[5]/div/select");
        //billing address
        By billaddress = By.Id("primary_billing");
        By shipAddress = By.Id("primary_shipping");
        By saveaddress = By.XPath("/html/body/div[2]/main/div[3]/div/form/div/div[1]/button/span");
        By saveaddressmessage = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div/div");
        By shipptomultipleaddress = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By removeitem = By.XPath("/html/body/div[2]/main/div[3]/div/form/div[2]/table/tbody/tr[3]/td[4]/a/span");
        By shippinginfo = By.XPath("/html/body/div[2]/main/div[3]/div/form/div[3]/div[1]/button/span");
        By shippingmethod = By.Id("s_method_33601_tablerate_bestway");
        By contiuetobillinginfo = By.XPath("/html/body/div[2]/main/div[3]/div/form/div[2]/div[1]/button/span");
        //
        By billinginfo = By.XPath("/html/body/div[3]/main/div[1]/h1/span");
        By gotorevieworder = By.XPath("/html/body/div[3]/main/div[3]/div/form/div[2]/div[1]/button/span");

        public void Is_Create_Shipping_Address_Visible()
        {
            //verify 'Create Shipping Address ' is visible
            GetElementText_And_Verify_Visibilit("Create Shipping Address", createshippingaddress);     
        }
        public void Company()
        {

            Find_Elements_and_Validate(company);
            SetTextIntoTextBox("Contour Software house pvt, Lahore", company);
        }
        public void Phone_No()
        {
            Find_Elements_and_Validate(phone);
            SetTextIntoTextBox("+923086065776", phone);
        }
        public void Street()
        {
            Find_Elements_and_Validate(street1);
            SetTextIntoTextBox("Po KH 7676,California", street1);
        }
        public void City()
        {
            Find_Elements_and_Validate(city);
            SetTextIntoTextBox("California", city);

        }
        
        public void Select_State()
        {
            Implicitwait(10);
            SelectDropDownItems(selectstate);
        }
        public void ZipCode()
        {
            Find_Elements_and_Validate(zipcode);
            SetTextIntoTextBox("76567", zipcode);
        }
        public void Select_Country()
        {
            Find_Elements_and_Validate(country);
            SelectDropDownItems(country);
        }

        //public void Check_default_billing_and_Shipping_address()
        //{
        //    check_CheckBox(billaddress);
        //    check_CheckBox(shipAddress);

        //}
        public void Save_Address()
        {
            Find_Elements_and_Validate(saveaddress);
            clickItems(saveaddress);
           
        }
        public void Is_saved_message_showing()
        {
            Sleep(5);
            //verify 'You saved the address.'is visible
            GetElementText_And_Verify_Visibilit("You saved the address.", saveaddressmessage);
        }
        public void Ship_to_multiple_address_Showing()
        {
            //verify 'Ship to Multiple Addresses'is visible
            GetElementText_And_Verify_Visibilit("Ship to Multiple Addresses", shipptomultipleaddress);
        }
        public void Remove_Item()
        {
            Find_Elements_and_Validate(removeitem);
            clickItems(removeitem);
        }

        public void GoTo_Shipping_Info()
        {
            Find_Elements_and_Validate(shippinginfo);
            clickItems(shippinginfo);
        }
        public void Shipping_Method_Flat_rate()
        {
            Find_Elements_and_Validate(shippingmethod);
            Implicitwait(5);
            clickItems(shippingmethod);    
        }
        public void Contiue_To_BillingInfo()
        {
            Find_Elements_and_Validate(contiuetobillinginfo);
            //contiue to billing info
            clickItems(contiuetobillinginfo);
        }
        //verify 'Billing Information' is visible
        public void Is_Billing_Info_Visible()
        {
            
            GetElementText_And_Verify_Visibilit("Billing Information", billinginfo);
            Sleep(2);
            Find_Elements_and_Validate(gotorevieworder);
            clickItems(gotorevieworder);
        }
      
        public void Create_Stark_shipping_address()
        {
            Is_Create_Shipping_Address_Visible();
            Company();
            Phone_No();
            Street();
            City();
           Select_State();
            ZipCode();
            Select_Country();
            Save_Address();
            Is_saved_message_showing();
            Ship_to_multiple_address_Showing();
            Remove_Item();
            GoTo_Shipping_Info();
            Contiue_To_BillingInfo();
            Is_Billing_Info_Visible();
     
        }


    }
}
