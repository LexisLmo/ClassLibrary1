//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;

//namespace ClassLibrary1
//{
//   public class Class2
//    {
        
       
//        private IWebDriver driver;
//        public Class2(IWebDriver driver)
//        {
//            this.driver = driver;
//            PageFactory.InitElements(driver, this);
//        }

//        [FindsBy(How = How.XPath, Using = "//*[@id='pod - content - z8rL9gk']/ul/li/ul[1]/li[2]/button")]
//        private IWebElement about;

//        public void cliclbutton()
//        {
//            about.Click();
//        }
//        public void goToPage()
//        {
//            driver.Navigate().GoToUrl("https://advance.lexis.com");
//        }
//    }
//}
