using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using SQABootCampFinalProject.PageObjectModel.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQABootCampFinalProject.PageObjectModel.Browser
{
    public class BrowserClass: CommonMethodClass
    {
        public static void SetUpApplication(string Browser)
        {
        //IWebDriver driver;
            if (Browser == "Edge")

            {
                EdgeOptions edgeOptions = new EdgeOptions();
                edgeOptions.AddArguments("--start-maximized");
                edgeOptions.AddArguments("disable-pop-up-blocking");
                edgeOptions.AddArguments("disable-extensions");
                driver = new EdgeDriver(edgeOptions);
                driver.Url = "https://magento.softwaretestingboard.com";

            }

            else if (Browser == "Chrome")
            {
                ChromeOptions option = new ChromeOptions();
                option.AddArguments("--start-maximized");

                option.AddArguments("disable-pop-up-blocking");
                option.AddArguments("disable-extensions");
                 driver = new ChromeDriver(option);
                driver.Url = "https://magento.softwaretestingboard.com";

            }

            else if (Browser == "FireFox")
            {
                FirefoxOptions firefoxOptions = new FirefoxOptions();

                firefoxOptions.AddArguments("--start-maximized");
                firefoxOptions.AddArguments("disable-pop-up-blocking");
                firefoxOptions.AddArguments("disable-extensions");
                driver = new FirefoxDriver(firefoxOptions);

                driver.Url = "https://magento.softwaretestingboard.com";

            }
            

        }

    }
}
