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
    public class PlaceOrder:CommonMethodClass
    {
        By ispaymentmethodVisible = By.XPath("/html/body/div[3]/main/div[2]/div/div[2]/div[4]/ol/li[3]/div/form/fieldset/div[1]/div/div/div[1]");
        //place order
        By order = By.XPath("//button[@class='action primary checkout']");
        By ispurchasemsgVisible = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By revieworder = By.XPath("/html/body/div[2]/main/div[1]/h1/span");
        By placeorder = By.Id("review-button");

        public void ThankYou_for_purchase_visible()
        {
            //verify 'Thank you for your purchase!' is visible
            GetElementText_And_Verify_Visibilit("Thank you for your purchase!", ispurchasemsgVisible);

        }
        public void Place_Order()
        {
            //verify 'Payment Method' is visible
            GetElementText_And_Verify_Visibilit("Payment Method", ispaymentmethodVisible);
            Sleep(3);
            Find_Elements_and_Validate(order);
            clickItems(order);
            //explicit wait
            ExplicitWait(10);
            ThankYou_for_purchase_visible();
           
        }
        //verify 'Review Order' is visible
        public void Is_review_Order_Visible()
        {
            GetElementText_And_Verify_Visibilit("Review Order", revieworder);

        }
        public void Plcae_Order_of_Stark_fundamental_Hoodie()
        {
            Is_review_Order_Visible();
            //scroll to bottom
            Scroll_To_Bottom();
            Find_Elements_and_Validate(placeorder);
            clickItems(placeorder);
            ThankYou_for_purchase_visible();
        }

    }
}
