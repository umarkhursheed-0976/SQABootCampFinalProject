using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
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
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_Autumn_puliie_Item_Into_Cart_Update_and_Delete();
            Close();
        }
        /*  Apply  BVA and ECP                           
        valid boundaries 1,2,36,75
       Invalid boundaries 0,76
        */
        [TestMethod]
        public void AddItems_into_Cart_With_Valid_Boundries()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();

            obj.Add_Valid_Boundries();
            Close();

        }
        [TestMethod]
        public void AddItems_into_Cart_With_InValid_Boundries()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_invalid_Boundries();
            Close();

        }
        [TestMethod]
        public void Addtocart_Without_Size_color_and_Quantity()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_Without_SizeColorquantity();
            Close();

        }
        [TestMethod]
        public void AddTocart_Without_color_and_Quantity()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_Without_ColourAndQuantity();
            Close();

        }
        [TestMethod]
        public void AddTocart_Without_Quantity()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_Without_Quantity();
            Close();

        }
        [TestMethod]
        public void Addtocart_With_Invalid_Quantity()
        {
            exParentTest = extentReport.CreateTest(TestContext.TestName);
            exChildTest = exParentTest.CreateNode("Login");
            SetUpApplication();
            CommonClass obj = new CommonClass();
            obj.Add_Invalid_quantity();
            Close();
        }




    }
}

