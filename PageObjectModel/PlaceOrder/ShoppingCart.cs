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

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class ShoppingCart:CommonMethodClass
    {
       
        By isvisibleshoppingcart = By.XPath("/html/body/div[2]/main/div[1]/h1/span");

        By shippingh = By.Id("block-shipping-heading");
        //drop down
        By Summary = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/div[1]/div[2]/form[1]/fieldset/div[1]/div/select");
        By state = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/div[1]/div[2]/form[1]/fieldset/div[2]/div/select");
        By zipcode = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/div[1]/div[2]/form[1]/fieldset/div[4]/div/input");
        By proceed = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/ul/li[1]/button/span");
        //stark
        By multipleaddress = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/ul/li[2]/a/span");
        //autum pullie locator
        By editcart = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/div/a[1]");
        //delete item from shopping cart
        By deleteAutumPulliefromcart = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/form/div[1]/table/tbody/tr[2]/td/div/a[2]");
        

        public void Is_Shopping_cart_Visible()
        {
            //verify 'Shopping Cart'is visible
            GetElementText_And_Verify_Visibilit("Shopping Cart", isvisibleshoppingcart);
        }
        public void Shipping()
        {
            Find_Elements_and_Validate(shippingh);
            clickItems(shippingh);

        }
        public void Select_Drop_Down()
        {
            Find_Elements_and_Validate(Summary);
            MultipleItems_From_Drop_Down(Summary);
        }
        public void Select_State()
        {
            Find_Elements_and_Validate(state);
            SelectDropDownItems(state);
        }
        public void ZipCode()
        {
            Find_Elements_and_Validate(zipcode);
            SetTextIntoTextBox("76567", zipcode);
            Sleep(5);
        }
        public void Proceed()
        {
            Find_Elements_and_Validate(proceed);
            Scroll_To_Element(proceed);
            Perform_Action(proceed);
            clickItems(proceed);
            Sleep(7);
        }
        //edit shopping cart
        public void Edit_Shopping_Cart()
        {
            clickItems(editcart);
            Sleep(2);
        }
      
        public void CheckOut_Multiple_Address()
        {
            Find_Elements_and_Validate(multipleaddress);
            Scroll_To_Bottom();
            Perform_Action(multipleaddress);
            clickItems(multipleaddress);
            Sleep(4);

        }
        public void Shopping_Cart_Ingrid()
        {
            Is_Shopping_cart_Visible();
            Shipping();
            Select_Drop_Down();
            Select_State();
            ZipCode();
            Proceed();
        }
        public void Shopping_Cart_Stark_Fundamental_Hoodie()
        {
            Is_Shopping_cart_Visible(); 
            Shipping();
            Select_Drop_Down();
            Select_State();
            ZipCode();
            CheckOut_Multiple_Address();
        }
        public void Shopping_Cart_Autumn_pullie_Edit()
        {
            Is_Shopping_cart_Visible();
            Edit_Shopping_Cart();
        }
        public void Delete_Autum_Pullie_item_from_Cart()
        {
            Is_Shopping_cart_Visible();
            clickItems(deleteAutumPulliefromcart);

        }




    }
}
