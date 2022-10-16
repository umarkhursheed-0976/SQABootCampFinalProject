using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home
{
    [TestClass]
    public class UpdateCart:CommonMethodClass
    {
        //add reviews onto item
        By reviews = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[2]/div[2]/a[2]");
        By rating = By.Id("Rating_5_label");
        By nickname = By.Id("nickname_field");
        By summary = By.Id("summary_field");
        By reviewbox = By.Id("review_field");
        By submit = By.XPath("/html/body/div[2]/main/div[2]/div/div[3]/div/div[6]/div[2]/div[2]/form/div/div/button/span");
        By updatecart = By.Id("product-updatecart-button");
        By cartupdatemessage = By.XPath("/html/body/div[2]/main/div[2]/div[2]/div/div/div");
        By isautumnpullie = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[1]/h1/span");

        public void Is_Autum_Pullie_Visible()
        {
            //verify 'Autumn Pullie' is visible
            GetElementText_And_Verify_Visibilit("Autumn Pullie", isautumnpullie);

        }
        //Add reviews
        public void Add_reviews()
        {
            clickItems(reviews);
            Scroll_To_Element(rating);
            clickItems(rating);
            SetTextIntoTextBox("Umar", nickname);
            SetTextIntoTextBox("I think it should give best quality", summary);
            SetTextIntoTextBox("Looking good", reviewbox);
            clickItems(submit);

        }
        public void Add_new_Size_Color_And_quantity()
        {
            clickItems(s);
            clickItems(purple);
            Clear(quantity);
            Sleep(2);
            SetTextIntoTextBox("35", quantity);
        }
        public void Click_UpdateCart()
        {
            clickItems(updatecart);
            Sleep(2);
            //verify 'Autumn Pullie was updated in your shopping cart.'is visible
            GetElementText_And_Verify_Visibilit("Autumn Pullie was updated in your shopping cart.", cartupdatemessage);
        }

        public void Update_Shopping_Cart()
        {
            Is_Autum_Pullie_Visible();
            Add_reviews();
            Add_new_Size_Color_And_quantity();
            Click_UpdateCart();
        }

    }
}
