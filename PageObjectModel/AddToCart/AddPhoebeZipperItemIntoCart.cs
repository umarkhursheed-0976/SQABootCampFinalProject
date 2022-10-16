using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABootCampFinalProject.PageObjectModel.AddToCart

{
    [TestClass]
    public class AddPhoebeZipperIntoCart : CommonMethodClass
    {
        //phoebe_Zipper locator
        By isphoebezippervisible = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");
        By delete = By.XPath("/html/body/div[2]/header/div[2]/div[1]/div/div/div/div[2]/div[4]/ol/li/div/div/div[3]/div[2]/a");
        By confirmdelete = By.XPath("/html/body/div[4]/aside[2]/div[2]/footer/button[2]/span");
        By errormessage = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        By phobeaddedintocartmessage = By.XPath("/html/body/div[2]/main/div[1]/div[2]/div/div/div");
        By sizeErrorMessage = By.Id("super_attribute[143]-error");
        By colorErrorMessage = By.Id("super_attribute[93]-error");
        By quantityError = By.Id("qty-error");

        public void Is_PhoebeZipper_Visible()
        {
            //verify 'Phoebe Zipper Sweatshirt' is visibl
            GetElementText_And_Verify_Visibilit("Phoebe Zipper Sweatshirt", isphoebezippervisible);
        }
        //verify 'You added Phoebe Zipper Sweatshirt to your shopping cart.'is visible
        public void Is_visible_Phoebe_Added_IntoCart()
        {
            GetElementText_And_Verify_Visibilit("You added Phoebe Zipper Sweatshirt to your shopping cart.", phobeaddedintocartmessage);

        }
        //verify 'Please enter a quantity greater than 0.' is visible
        public void Verify_Error_Message_Showing_for_Invalid_quantity()
        {
            GetElementText_And_Verify_Visibilit("Please enter a quantity greater than 0.", quantityError);
        }
        public void Verify_Requested_quantityNot_Awailable_Visible()
        {
            //verify 'The requested qty is not available'is visible
            GetElementText_And_Verify_Visibilit("The requested qty is not available", errormessage);
        }
        //verify 'This is a required field.' is showing
        public void Verify_Size_Error_Message_Showing()
        {
            GetElementText_And_Verify_Visibilit("This is a required field.", sizeErrorMessage);
        }
        //verify 'This is a required field.' is showing
        public void Verify_Color_Error_Message_Showing()
        {
            GetElementText_And_Verify_Visibilit("This is a required field.", colorErrorMessage);
        }
        //verify 'Please enter a valid number in this field.'is showing
        public void Verify_Empty_Quantity_Error_Showing()
        {
            GetElementText_And_Verify_Visibilit("Please enter a valid number in this field.", quantityError);
        }
        public void RemoveQuantity()
        {
            Find_Elements_and_Validate(quantity);
            Clear(quantity);
        }
        public void Select_Phoebe_Zipper_Size()
        {
            clickItems(xl);
            Sleep(2);
        }
        public void Select_Phoebe_Zipper_Color()
        {

            clickItems(purple);
        }
        public void AddToCart()
        {

            Find_Elements_and_Validate(addtocartt);
            //implicit wait
            Implicitwait(20);
            clickItems(addtocartt);
            Sleep(5);
        }
        public void AddToCart_Phoebe_With_valid_Boundry()
        {
            Is_PhoebeZipper_Visible();
            Select_Phoebe_Zipper_Size();
            Select_Phoebe_Zipper_Color();
            RemoveQuantity();
            SetTextIntoTextBox("1", quantity);
            AddToCart();
            Sleep(2);
            Is_visible_Phoebe_Added_IntoCart();
            clickItems(cartitems);
            Implicitwait(13);
            clickItems(delete);
            Sleep(2);
            clickItems(confirmdelete);
            Sleep(2);
            Clear(quantity);
            SetTextIntoTextBox("2", quantity);
            AddToCart();
            Sleep(2);
            Is_visible_Phoebe_Added_IntoCart();
            clickItems(cartitems);
            Implicitwait(10);
            clickItems(delete);
            Sleep(2);
            clickItems(confirmdelete);
            Sleep(2);
            Clear(quantity);
            SetTextIntoTextBox("36", quantity);
            AddToCart();
            Sleep(2);
            Is_visible_Phoebe_Added_IntoCart();
            clickItems(cartitems);
            Implicitwait(15);
            clickItems(delete);
            Sleep(2);
            clickItems(confirmdelete);
            Sleep(2);
            Clear(quantity);
            SetTextIntoTextBox("75", quantity);
            AddToCart();
            Is_visible_Phoebe_Added_IntoCart();
        }
        public void AddToCart_phoebe_InvalidBoundries()
        {
            Is_PhoebeZipper_Visible();
            Select_Phoebe_Zipper_Size();
            Select_Phoebe_Zipper_Color();
            RemoveQuantity();
            Find_Elements_and_Validate(quantity);
            SetTextIntoTextBox("0", quantity);
            AddToCart();
            Verify_Error_Message_Showing_for_Invalid_quantity();
            Clear(quantity);
            SetTextIntoTextBox("76", quantity);
            AddToCart();
            Verify_Requested_quantityNot_Awailable_Visible();

        }
        public void AddToCart_phoebe_WithoutSizeColorAndQuantity()
        {
            Is_PhoebeZipper_Visible();
            Clear(quantity);
            AddToCart();
            Verify_Size_Error_Message_Showing();
            Verify_Color_Error_Message_Showing();
            Verify_Empty_Quantity_Error_Showing();
        }
        public void AddToCart_phoebe_WithoutColorAndQuantity()
        {
            Is_PhoebeZipper_Visible();
            Select_Phoebe_Zipper_Size();
            Clear(quantity);
            AddToCart();
            Verify_Color_Error_Message_Showing();
            Verify_Empty_Quantity_Error_Showing();

        }
        public void AddToCart_phoebe_WithoutQuantity()
        {
            Is_PhoebeZipper_Visible();
            Select_Phoebe_Zipper_Size();
            Select_Phoebe_Zipper_Color();
            Clear(quantity);
            AddToCart();
            Verify_Empty_Quantity_Error_Showing();

        }
        public void AddToCart_phoebe_With_Invalid_Quanity()
        {
            Is_PhoebeZipper_Visible();
            Select_Phoebe_Zipper_Size();
            Select_Phoebe_Zipper_Color();
            Clear(quantity);
            SetTextIntoTextBox("-4", quantity);
            AddToCart();
            Verify_Error_Message_Showing_for_Invalid_quantity();

        }



    }
}


