using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using SQABootCampFinalProject.PageObjectModel.Browser;
using SQABOOTCAUMP01_FINAL_PROJECT_Umar_Khursheed_.PageObjectModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABootCampFinalProject.PageObjectModel.AddToCart

{
    [TestClass]
    public class AddToCartTestCases : CommonMethodClass
    {
        [TestMethod]
        public void Add_Item_IntoCart_Update_Delete()
        {
            BrowserClass.SetUpApplication("Chrome");
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
         
            CommonClass obj = new CommonClass();
            obj.Add_Autumn_puliie_Item_Into_Cart_Update_and_Delete();
           
        }
        /*  Apply  BVA and ECP                           
        valid boundaries 1,2,36,75
       Invalid boundaries 0,76
        */
        [TestMethod]
        public void AddItems_into_Cart_With_Valid_Boundries()
        {
            BrowserClass.SetUpApplication("Edge");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
            CommonClass obj = new CommonClass();
            obj.Add_Valid_Boundries();
           
        }
        [TestMethod]
        public void AddItems_into_Cart_With_InValid_Boundries()
        {
            BrowserClass.SetUpApplication("FireFox");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
            CommonClass obj = new CommonClass();
            obj.Add_invalid_Boundries();
         

        }
        [TestMethod]
        public void Addtocart_Without_Size_color_and_Quantity()
        {
            BrowserClass.SetUpApplication("Chrome");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");


            CommonClass obj = new CommonClass();
            obj.Add_Without_SizeColorquantity();
           

        }
        [TestMethod]
        public void AddTocart_Without_color_and_Quantity()
        {
            BrowserClass.SetUpApplication("Chrome");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
            
            CommonClass obj = new CommonClass();
            obj.Add_Without_ColourAndQuantity();
           

        }
        [TestMethod]
        public void AddTocart_Without_Quantity()
        {
            BrowserClass.SetUpApplication("Edge");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
            CommonClass obj = new CommonClass();
            obj.Add_Without_Quantity();
          

        }
        [TestMethod]
        public void Addtocart_With_Invalid_Quantity()
        {
            BrowserClass.SetUpApplication("FireFox");

            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Add To Cart");
           
            CommonClass obj = new CommonClass();
            obj.Add_Invalid_quantity();
          
        }




    }
}

