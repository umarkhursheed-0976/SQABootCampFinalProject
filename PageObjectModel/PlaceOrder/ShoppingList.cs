using OpenQA.Selenium;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABOOTCAUMP01_FINAL_PROJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.NewFolder1
{
    public class ShoppingList:CommonMethodClass
    {
        By list = By.Id("mode-list");
        By grid = By.Id("mode-grid");
        By sort = By.Id("sorter");
        By orderby = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[2]/div[3]/a");
        By style = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div/div[1]/div[1]");
        By insideStyleTee = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div/div[1]/div[2]/ol/li/a/span");
        By size = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");
        By medium = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/div/div/a[3]/div");
        By price = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");
        By selectprice = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/ol/li[1]/a/span[2]");
        By color = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");
        By selectcolor = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/div/div/a[2]/div");
        By material = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");

        By selectmatrial = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/ol/li[9]/a");
        By collection = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");

        By selectcollection = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/ol/li[2]/a/span");

        By performance = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");
        By performaneNo = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/ol/li[2]/a/span");
        //To do
        //By recommendation = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[1]");
        //By recommendno = By.XPath("/html/body/div[2]/main/div[3]/div[2]/div/div[2]/div[3]/div[1]/div[2]/ol/li/a/span");
        By remove = By.XPath("//a[@title=\"Remove Eco Collection No\"]");
        By movetoitem1 = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[1]/div/a/span/span/img");
        By addtocart = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[1]/div/div/div[4]/div/div[1]/form/button/span");
        By clickitem = By.XPath("/html/body/div[2]/main/div[3]/div[1]/div[3]/ol/li[2]/div/div/strong/a");
        public void View_Mode()
        {
            //Grid view mode
            //Assert the element
            Find_Elements_and_Validate(list);
            //clcik the element
            clickItems(list);
            //wait
            Sleep(3);
            //List view mode
            //implicit wait
            Implicitwait(50);
            Find_Elements_and_Validate(grid);
            clickItems(grid);

        }
        public void Sort_By()
        {

            //select drop down
            SelectDropDownItems(sort);
            Sleep(2);
            Sleep(3);

        }
        public void Select_Order()
        {
            //here we store our web elements into two different variables to perform action.In other
            //case it would generate stale element exception.Actually in javascript when we hit our target same time.It removes element that's why we store our web element into another variable
            //implicit wait
            Implicitwait(40);
            AscDescOrder(orderby);
        }

        public void Select_Style()
        {
            Find_Elements_and_Validate(style);
            clickItems(style);
        }
        public void Tee()
        {
            Find_Elements_and_Validate(insideStyleTee);
            clickItems(insideStyleTee);
        }
        public void Select_Size()
        {
            Find_Elements_and_Validate(size);
            clickItems(size);
        }
        public void SizeTypeMedium()
        {
            //implicit wait
            Implicitwait(30);
            Find_Elements_and_Validate(medium);
            clickItems(medium);
        }
        public void Price()
        {
            Find_Elements_and_Validate(price);
            clickItems(price);
        }
        public void SelectPrice()
        {
            Find_Elements_and_Validate(selectprice);
            clickItems(selectprice);
        }
        public void Color()
        {
            //implicit wait
            Implicitwait(30);
            Find_Elements_and_Validate(color);
            clickItems(color);
        }
        public void SelectColor()
        {
            //explicit wait
            ExplicitWait(30);
            Find_Elements_and_Validate(selectcolor);
            clickItems(selectcolor);
        }
        public void Material()
        {
            Find_Elements_and_Validate(material);
            clickItems(material);
        }
        public void SelectMaterial()
        {
            Find_Elements_and_Validate(selectmatrial);
            clickItems(selectmatrial);
        }
        public void Collection()
        {
            Find_Elements_and_Validate(collection);
            clickItems(collection);
        }
        public void SelectCollection()
        {
            Find_Elements_and_Validate(selectcollection);
            clickItems(selectcollection);
        }
        public void Performane()
        {
            Find_Elements_and_Validate(performance);
            clickItems(performance);
        }
        public void Select_By_Performance()
        {
            Find_Elements_and_Validate(performaneNo);
            clickItems(performaneNo);

        }
        //public void Recommended()
        //{
        //    Find_Elements_and_Validate(recommendation);
        //    clickItems(recommendation);
        //}
        //[Timeout(70)]
        //public void Recommended_By_No()
        //{

        //    Find_Elements_and_Validate(recommendno);
        //    driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromMinutes(2));
        //    clickItems(recommendno);
        //}
        public void RemoveFromSelectedList()
        {
            Find_Elements_and_Validate(remove);
            clickItems(remove);
        }
        public void MoveToItem()
        {
            Find_Elements_and_Validate(movetoitem1);
            Perform_Action(movetoitem1);
        }
        public void AddToCartItem()
        {
            Find_Elements_and_Validate(addtocart);
            clickItems(addtocart);
        }
        public void ClickItem()
        {
            Find_Elements_and_Validate(clickitem);
            GetElementstate(clickitem);
            clickItems(clickitem);
           
        }
        public void TeesMethod()
        {
            View_Mode();
            Sort_By();
            Select_Order();
            Select_Style();
            Tee();
            Select_Size();
            SizeTypeMedium();
            Price();
            SelectPrice();
            Color();
            SelectColor();
            Material();
            SelectMaterial();
            Collection();
            SelectCollection();
            Performane();
            Select_By_Performance();
            //     Recommended();
            //  Recommended_By_No();
            RemoveFromSelectedList();
            MoveToItem();
            AddToCartItem();
            ClickItem();
        }

    }
}
