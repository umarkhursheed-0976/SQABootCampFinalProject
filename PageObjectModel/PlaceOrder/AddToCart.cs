using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver.Core.Misc;
using MongoDB.Driver.Core.WireProtocol.Messages;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class AddToCartC:CommonMethodClass
    {   
        By atomicEnduranceAddtocartMsgVisible = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        //check out cart items and proceed further
        By checkout = By.Id("top-cart-btn-checkout");
        //ingridjacket into cart
        //verify visibility
        By isingridjacketVisible = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");
        By ingridaddtocartmessageshowing = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        // stark item locators
        By isstarkitemvisible = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");
        By starkaddtocartmessage = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        By starkintocomparisonlist = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");

        //Autum pullie item locators
        By isautumnpullie = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");
        By isvisibleaddtocartautumnpullie = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        public By isAtomicEndurancevisible = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");



        //operational methods

        public void Is_Atomic_RunningTee_Visible()
        {
            ExplicitWait(10);
            //verify 'Atomic Endurance Running Tee (Crew-Neck)'is visible
            GetElementText_And_Verify_Visibilit("Atomic Endurance Running Tee (Crew-Neck)", isAtomicEndurancevisible);
        }
        public void Is_Ingridjacket_Visible()
        {
            //verify 'Ingrid Running Jacket' is visible
            GetElementText_And_Verify_Visibilit("Ingrid Running Jacket", isingridjacketVisible);
        }
        public void Is_Stark_Fun_Hoodie_Visible()
        {
            //verify 'Stark Fundamental Hoodie' is visible
            GetElementText_And_Verify_Visibilit("Stark Fundamental Hoodie", isstarkitemvisible);
        }
        public void Select_Size()
        {

            Find_Elements_and_Validate(xs);
            clickItems(xs);
            Sleep(2);
            Find_Elements_and_Validate(s);
            clickItems(s);
            Sleep(2);
            Find_Elements_and_Validate(m);
            clickItems(m);
            Sleep(2);
            Find_Elements_and_Validate(l);
            clickItems(l);
            Sleep(2);
            Find_Elements_and_Validate(xl);
            clickItems(xl);
            Sleep(2);
        }
        public void Select_Black_Blue_Red_Color()
        {
            //impliocit wait
            Implicitwait(20);
            Find_Elements_and_Validate(red);
            clickItems(red);
            Sleep(3);
            Find_Elements_and_Validate(black);
            clickItems(black);
            Sleep(3);
            Find_Elements_and_Validate(blue);
            clickItems(blue);
            Sleep(4);
            

        }
        public void Select_Orange_Red_White_Color()
        {
            //implicit wait
            Implicitwait(20);
            Find_Elements_and_Validate(orange);
            clickItems(orange);
            Sleep(3);
            Find_Elements_and_Validate(white);
            clickItems(white);
            Sleep(3);
            Find_Elements_and_Validate(red);
            clickItems(red);
            Sleep(3);
        }
        public void Select_Strak_Item_Color()
        {
            clickItems(blue);
            Sleep(1);
            clickItems(purple);
            clickItems(black);
            Sleep(1);
        }
        public void Select_ItemQuantity()
        {
            Find_Elements_and_Validate(quantity);
            Clear(quantity);
            SetTextIntoTextBox("10", quantity);
            Sleep(2);

        }
        public void AddToCart()
        {

            Find_Elements_and_Validate(addtocartt);
            //implicit wait
            Implicitwait(20);
            clickItems(addtocartt);
            Sleep(5);
        }
        //view cart items
        public void CartItems()
        {
            Find_Elements_and_Validate(cartitems);
            Perform_Action(cartitems);
            //implicitnwait
            Implicitwait(40);
            clickItems(cartitems);
        }
        
        public void AtomicEndurance_AddIntoCart_Message_Showing()
        {
            //verify 'You added Atomic Endurance Running Tee (Crew-Neck) to your shopping cart.' is visible
            GetElementText_And_Verify_Visibilit("You added Atomic Endurance Running Tee (Crew-Neck) to your shopping cart.", atomicEnduranceAddtocartMsgVisible);

        }
        public void Ingrid_Added_IntoCart_Showing()
        {
            //verify 'You added Ingrid Running Jacket to your shopping cart.' is visible
            GetElementText_And_Verify_Visibilit("You added Ingrid Running Jacket to your shopping cart.", ingridaddtocartmessageshowing);
        }
        public void StarK_added_Into_cart_Showing()
        {
            //verify 'You added Stark Fundamental Hoodie to your shopping cart.'is visible
            GetElementText_And_Verify_Visibilit("You added Stark Fundamental Hoodie to your shopping cart.", starkaddtocartmessage);
        }
        public void Stark_added_into_ComparisonList_Showing()
        {
            //verify 'You added product Stark Fundamental Hoodie to the comparison list.' is visible
            GetElementText_And_Verify_Visibilit("You added product Stark Fundamental Hoodie to the comparison list.",starkintocomparisonlist);

        }
        public void Is_Autum_Pullie_Visible()
        {
            //verify 'Autumn Pullie' is visible
            GetElementText_And_Verify_Visibilit("Autumn Pullie", isautumnpullie);
            
        }
        public void Autumn_Pullie_Added_Into_ShoppingCart_Showing()
        {
            //verify 'You added Autumn Pullie to your shopping cart.' is visible
            GetElementText_And_Verify_Visibilit("You added Autumn Pullie to your shopping cart.", isvisibleaddtocartautumnpullie);
        } 
       
        public void Select_Autum_Pullie_Size_and_Color()
        {
            clickItems(l);
            Sleep(2);
            clickItems(red);
        }


        public void Add_To_Compare_List()
        {
            Find_Elements_and_Validate(addtocomparelis);
            clickItems(addtocomparelis);
            Sleep(4);
        }
        public void Add_To_Wish_List()
        {
            Find_Elements_and_Validate(addtowishlist);
            clickItems(addtowishlist);
        }
       
        //proceed to check out
        public void Proceed_To_CheckOut()
        {
            clickItems(checkout);
            Sleep(10);
        }
        public void View_and_Edit_CartItems()
        {
            CartItems();
            Implicitwait(30);
            Find_Elements_and_Validate(viewcart);
            clickItems(viewcart);

        }


        public void Add_AtomicEndurance_Into_Cart()
        {
            Is_Atomic_RunningTee_Visible();
            Select_Size();
            Select_Black_Blue_Red_Color();
            Select_ItemQuantity();
            AddToCart();
            AtomicEndurance_AddIntoCart_Message_Showing();
            Add_To_Compare_List();
            CartItems();
            Proceed_To_CheckOut();
        }
        public void Add_IngridRunning_into_Cart()
        {
            Is_Ingridjacket_Visible();
            Select_Size();
            Select_Orange_Red_White_Color();
            Select_ItemQuantity();
            AddToCart();
            Ingrid_Added_IntoCart_Showing();
            Add_To_Compare_List();
            Add_To_Wish_List(); 

        }
        public void Add_starkItem_IntoCart()
        {
            Is_Stark_Fun_Hoodie_Visible();
            Select_Size();
            Select_Strak_Item_Color();
            Select_ItemQuantity();
            AddToCart();
            StarK_added_Into_cart_Showing();
            Add_To_Compare_List();
            Stark_added_into_ComparisonList_Showing();
            View_and_Edit_CartItems();
        }
        public void Add_Autum_IntoCart()
        {
            Is_Autum_Pullie_Visible();
            Select_Autum_Pullie_Size_and_Color();
            Select_ItemQuantity();
            AddToCart();
            Autumn_Pullie_Added_Into_ShoppingCart_Showing();
        }
        
      
      

    }
}
