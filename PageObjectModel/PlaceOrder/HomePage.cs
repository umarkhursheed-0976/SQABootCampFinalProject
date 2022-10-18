using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.NewFolder1
{
    [TestClass]
    public class Homepage : CommonMethodClass
    {
        //Men Section
      
        By men = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[3]/a/span[2]");
        By top = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[3]/ul/li[1]/a/span[2]");
        By teens = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[3]/ul/li[1]/ul/li[3]/a/span");
        By swaeathoodies = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[3]/ul/li[1]/ul/li[2]/a/span");
        By movetostarkitem = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[8]/div/a/span/span/img");


        //Women Section
        By movetowomen = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[2]/a/span[2]");
        By movetotop = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[2]/ul/li[1]/a/span[2]");
        By movetojacket = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[2]/ul/li[1]/ul/li[1]/a/span");
        By movetoitem = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[9]/div/div/strong/a");
        By hoodiesansshirts = By.XPath("/html/body/div[2]/div[1]/div/div[2]/nav/ul/li[2]/ul/li[1]/ul/li[2]/a/span");
        By movetoautumpullie = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[10]/div/a/span/span/img");
        By clcikautumPullie = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[10]/div/div/strong/a");
         By clickphoebe = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[6]/div/a/span/span/img");


        public void Is_HomePage_visible()
        {
            //Verify that home page is visible successfully
            GetElementText_And_Verify_Visibilit("New Luma Yoga Collection", hompagevisibility);
        }

        //Men Section
        public void MoveToMen()
        {
            //implicitwait
               Implicitwait(40);
            //perform actions
            Perform_Action(men);
        }
        public void MoveToMenTop()
        {

            //validate the element
            Find_Elements_and_Validate(top);
            //implicitwait
            Implicitwait(40);
            //perform actions
            Perform_Action(top);
            Sleep(3);
        }
        public void MoveToTeenSection()
        {
            //validate the element
            Find_Elements_and_Validate(teens);
            //clcik the element
            clickItems(teens);
        }
        //Women Section
        public void MoveToWomen()
        {
            
            //implicit wait
            Implicitwait(20);
            Find_Elements_and_Validate(movetowomen);
            Perform_Action(movetowomen);
        }
        public void MoveToWomenTop()
        {
            Find_Elements_and_Validate(movetotop);
            Perform_Action(movetotop);

        }
        public void MoveToHoodiesAndShirts()
        {
            Find_Elements_and_Validate(hoodiesansshirts);
            clickItems(hoodiesansshirts);

        }
        public void Click_To_Autumn_Pullie()
        {
            Perform_Action(movetoautumpullie);
            clickItems(clcikautumPullie);
           
        }
        public void MoveToJacketSection()
        {
            Find_Elements_and_Validate(movetojacket);
            clickItems(movetojacket);
        }
        public void MoveToItem()
        {
            Find_Elements_and_Validate(movetoitem);
            clickItems(movetoitem);
        }
        public void StarkItem()
        {
            clickItems(swaeathoodies);
            //validate the element
            Find_Elements_and_Validate(movetostarkitem);
            //clcik the element
            clickItems(movetostarkitem);
        }
        public void Click_PhobeZipper_Item()
        {
            Perform_Action(clickphoebe);
            //  Find_Elements_and_Validate(element4);
            clickItems(clickphoebe);
        }
        public void MoveToAtomicEnduranceItem()
        {
            Is_HomePage_visible();
            MoveToMen();
        MoveToMenTop();
           MoveToTeenSection();
        }
        public void MoveToIngridRunningItem()
        {
            Is_HomePage_visible();
            MoveToWomen();
            MoveToWomenTop();
            MoveToJacketSection();
            MoveToItem();
        }
        public void Move_ToStark_Item()
        {
            MoveToMen();
            MoveToMenTop();
            StarkItem();
        }
        public void Move_To_Atomic_Pullie_Item()
        {
            MoveToWomen();
            MoveToWomenTop();
          MoveToHoodiesAndShirts();
            Click_To_Autumn_Pullie();
        }
        public void MoveTo_Phoebe_Zipper()
        {
            MoveToWomen();
            MoveToWomenTop();
            MoveToHoodiesAndShirts();
            Click_PhobeZipper_Item();
        }
      

    }
}
