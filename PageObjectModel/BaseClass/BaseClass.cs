
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;
using System.IO;
using SQABootCampFinalProject.PageObjectModel.ExtentClass;

namespace SQABootCampFinalProject.PageObjectModel.BaseClass
{

    [TestClass]
    public class CommonMethodClass: ExtenReport
    {

        //Common Locators at add to cart page
        //size  
        public By xs = By.Id("option-label-size-143-item-166");
        public By s = By.Id("option-label-size-143-item-167");
        public By m = By.Id("option-label-size-143-item-168");
        public By l = By.Id("option-label-size-143-item-169");
        public By xl = By.Id("option-label-size-143-item-170");
        //color 
        public By black = By.Id("option-label-color-93-item-49");
        public By blue = By.Id("option-label-color-93-item-50");
        public By red = By.Id("option-label-color-93-item-58");
        public By orange = By.Id("option-label-color-93-item-56");
        public By white = By.Id("option-label-color-93-item-59");
        public By purple = By.Id("option-label-color-93-item-57");

        // view and edit cart locators
        public By cartitems = By.XPath("/html/body/div[2]/header/div[2]/div[1]/a");
        public By viewcart = By.XPath("/html/body/div[2]/header/div[2]/div[1]/div/div/div/div[2]/div[5]/div/a/span");
        //
        public By quantity = By.Id("qty");
        //add atomic endurance item into cart
        public By addtocartt = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[4]/form/div[2]/div/div/div[2]/button/span");
    public By hompagevisibility = By.XPath("/html/body/div[2]/main/div[3]/div/div[2]/div[1]/a/span/span[1]");

        public By addtowishlist = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[5]/div/a[1]/span");
        public By addtocomparelis = By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[5]/div/a[2]/span");
        //shipping common locators
        public By company = By.Name("company");
        public By street = By.Name("street[0]");
        public By city = By.Name("city");
        public By phone = By.Name("telephone");
        //login/signup
        public By signin = By.LinkText("Sign In");


        //log4net report
        public static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

       

        public static void SetUpApplication()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--start-maximized");
            option.AddArguments("disable-pop-up-blocking");
            option.AddArguments("disable-extensions");
            driver = new ChromeDriver(option);
            //          exParentTest.Log(Status.Info, "Chrome Browser Launched");
            driver.Url = "https://magento.softwaretestingboard.com";
            //     exParentTest.Log(Status.Info, "Apllication URL opened Successfully");

            //if (Browser.Equals("chrome"))
            //{
            //    ChromeOptions option = new ChromeOptions();
            //    option.AddArguments("--start-maximized");

            //    option.AddArguments("disable-pop-up-blocking");
            //    option.AddArguments("disable-extensions");
            //    driver = new ChromeDriver(option);
            //    driver.Url = "https://magento.softwaretestingboard.com";

            //}
            //else if (Browser.Equals("Edge"))

            //{
            //    EdgeOptions edgeOptions = new EdgeOptions();
            //    edgeOptions.AddArguments("--start-maximized");

            //    edgeOptions.AddArguments("disable-pop-up-blocking");
            //    edgeOptions.AddArguments("disable-extensions");
            //    driver = new EdgeDriver(edgeOptions);
            //    driver.Url = "https://magento.softwaretestingboard.com";
            //}
            //else if (Browser.Equals("FireFox"))
            //{
            //    FirefoxOptions firefoxOptions = new FirefoxOptions();

            //    firefoxOptions.AddArguments("--start-maximized");

            //    firefoxOptions.AddArguments("disable-pop-up-blocking");
            //    firefoxOptions.AddArguments("disable-extensions");
            //    driver = new FirefoxDriver(firefoxOptions);
            //    driver.Url = "https://magento.softwaretestingboard.com";
            //}

        }
        // Generate ExtentReport
       

        [AssemblyInitialize]
        public static void GetTestContext(TestContext test)
        {
            LogReport("TestReport");

        }

        [AssemblyCleanup]
        public static void ClassCleanUp()
        {
            extentReport.Flush();
        }

        [TestInitialize()]
        public void GetTestName()
        {
            Console.WriteLine(TestContext.TestName);
            LogReport(TestContext.TestName);
        }

        [TestCleanup()]
        public void TestClean()
        {
            driver.Close();
        }
        //common methods
        public void TakeScreenShot(Status status, string stepDetail)
        {
            string path = "C:\\Users\\raees\\source\\repos\\SQABootCampFinalProject\\ScreenShoots\\ScreenShoots" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtenReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public void Quit()
        {
            driver.Quit();
        }
        public void Close()
        {
            driver.Close();
        }
        public void TimeToPageLoad()
        {
            //set page load time for 15 secs
            driver.Manage().Timeouts().PageLoad = TimeSpan.
            FromSeconds(15);
        }
        public void MultipleItems_From_Drop_Down(By path)
        {

            IWebElement element = driver.FindElement(path);
            element.Click();
            //select by text
            var slctbytext = new SelectElement(element);
            slctbytext.SelectByText("Afghanistan");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //select by text
            var selctbytext = new SelectElement(element);
            selctbytext.SelectByText("Pakistan");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //select by value
            var slctbyvalue = new SelectElement(element);
            slctbyvalue.SelectByValue("VG");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            //select by index 
            var slctbyindex = new SelectElement(element);
            slctbyindex.SelectByIndex(14);
            Thread.Sleep(TimeSpan.FromSeconds(3));



        }
        public void Scroll_To_Element(By path)
        {
            try
            {
                IWebElement element = driver.FindElement(path);
                //scroll to element using javascript
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                exChildTest.Log(Status.Pass, "Scroll To Element");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "Element not found" + ex.ToString());
            }

        }
        public void Scroll_To_Bottom()
        {
            try
            {
                IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
                js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
                Sleep(3);
                exChildTest.Log(Status.Pass, "Scroll To Bottom Successfully");

            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "Scroll to Bottom Failed" + ex.ToString());
            }
        }
        public void Clear(By path)
        {
            try
            {
                driver.FindElement(path).Clear();
                exChildTest.Log(Status.Pass, "Successfully clear text from textbox");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "Failed! to clear text from textbox" + ex.ToString());
            }

        }
        public void Press_Space(By path)
        {
            IWebElement ele = driver.FindElement(path);
            ele.SendKeys(Keys.Space);
        }
        public void Implicitwait(int i)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(i);
        }
        public void ExplicitWait(int w)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(w));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
        }
        public void clickItems(By path)
        {
            try
            {
                driver.FindElement(path).Click();
                exChildTest.Log(Status.Pass, "Element is clickable");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "Element is not clickable/No such element found" + ex.ToString());
            }

        }


        public void Find_Elements_and_Validate(By path)
        {
            //element.Enabled and element.Displayed have separate spaces into memory
            //areEqual() always used for 2 different objects
            try
            {
                IWebElement element = driver.FindElement(path);
                Assert.AreEqual(element.Enabled, element.Displayed);
                exChildTest.Log(Status.Pass, "Element found and Validate");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "No such element" + ex.ToString());
            }
        }
        public void Elements_AreNotEqual(By path)
        {
            //aresame() always use checks the same objects, same 
            IWebElement element = driver.FindElement(path);
            Assert.AreNotEqual(element.Enabled, element.Displayed);
        }

        public void SetTextIntoTextBox(string data, By path)
        {
            try
            {
                WaitforElement(path).SendKeys(data);
               TakeScreenShot(Status.Pass, "Text successfully Set into TextBox");
            }
            catch (Exception ex)
            {
             TakeScreenShot(Status.Fail, "Failed to Enter text into TextBox: " + ex.ToString());
            }

        }
        public void GetElementText_And_Verify_Visibilit(string elementtext, By path)
        {
            string text;
            try
            {
                //  text = driver.FindElement(path).Text;
                text = WaitforElement(path).Text;

                Assert.AreEqual(elementtext, text);
                exChildTest.Log(Status.Pass, "Validation OK");
            }
            catch
            {
                try
                {
                    //  text = driver.FindElement(path).GetAttribute("value");
                     text = WaitforElement(path).GetAttribute("value");

                    Assert.AreEqual(text, elementtext);
                    exChildTest.Log(Status.Pass, "Validation OK");

                }
                catch
                {
                    //   text = driver.FindElement(path).GetAttribute("innerHTML");
                    text = WaitforElement(path).GetAttribute("innerHTML");
                    Assert.AreEqual(text, elementtext);
                    exChildTest.Log(Status.Fail,"Validation failed");

                }
            }
        }
        //Get element state enable/disable
        public string GetElementstate(By path)
        {
            string elementstate = driver.FindElement(path).GetAttribute("Disabled");
            if (elementstate == null)
            {
                elementstate = "enabled";
            }
            else if (elementstate == "true")
            {
                elementstate = "disabled";
            }
            return elementstate;
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void SelectDropDownItems(By path)
        {
            ////select by value
            //var sorter2 = driver.FindElement(path);
            //Assert.AreEqual(sorter2.Enabled, sorter2.Displayed);
            //var selctbyvalue = new SelectElement(sorter2);
            //selctbyvalue.SelectByValue("position");
            ////select by text
            //var sorter = driver.FindElement(path);
            //var slctbytext = new SelectElement(sorter);
            //slctbytext.SelectByText("Product Name");
            //  select by index
            try
            {
                var sorter1 = driver.FindElement(path);
                var slctbyindex = new SelectElement(sorter1);
                slctbyindex.SelectByIndex(2);
                exChildTest.Log(Status.Pass, "Successfully select element from drop down list");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "No such element found" + ex.ToString());
            }
        }

        public void check_CheckBox(By path)
        {
            try
            {
                IWebElement checkbox = driver.FindElement(path);
                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
                exChildTest.Log(Status.Pass, "Successfully, checked check box");
            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "No such element found" + ex.ToString());
            }

        }
        private bool IsPageReady(IWebDriver driver)
        {

            return ((IJavaScriptExecutor)driver)
                 .ExecuteScript("return document.readyState")
                 .Equals("complete");

        }
        private bool IsElementVisible(By by)
        {
            if (driver.FindElement(by)
               .Displayed || driver.FindElement(by).Enabled)
            {
                return true;
            }
            else
            { return false; }
        }
        public bool IsClickable(By by)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void PlaybackWait(int miliSeconds)
        {
            Thread.Sleep(miliSeconds);
        }

        public IWebElement WaitforElement(By by, int timeToReadyElement = 0)
        {
            IWebElement element = null;
            try
            {
                if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)
                {
                    PlaybackWait(timeToReadyElement * 1000);
                }
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
                element = driver.FindElement(by);
            }
            return element;
        }
        public void Perform_Action(By path)
        {

            IWebElement element = driver.FindElement(path);
            //Action Class in Selenium is a built-in feature provided by the selenium for handling keyboard and mouse events. 
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
        public void Sleep(int i)
        {
            Thread.Sleep(TimeSpan.FromSeconds(i));
        }
        public void AscDescOrder(By path)
        {
            try
            {
                IWebElement ord = driver.FindElement(path);
                ord.Click();
                //Thread.Sleep(TimeSpan.FromSeconds(2));
                IWebElement ord1 = driver.FindElement(path);
                ord1.Click();
                exChildTest.Log(Status.Pass, "Successfully,Move into Asc and Desc order ");

            }
            catch (Exception ex)
            {
                exChildTest.Log(Status.Fail, "Asc ,Desc failed" + ex.ToString());
            }

        }
        public bool isElementTextField(By path)
        {
            try
            {
                bool resultText = driver.FindElement(path).GetAttribute("type").Equals("text");
                bool resulPass = driver.FindElement(path).GetAttribute("type").Equals("password");
                if (resultText == true || resulPass == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

