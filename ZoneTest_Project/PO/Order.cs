using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ZoneTest_Project.Helpers;

namespace ZoneTest_Project.PO
{
    public class Order
    {
        public Order()
        {
            PageFactory.InitElements(App_Drivers.Driver, this);
        }
        Actions _actions = new Actions(App_Drivers.Driver);

        public void TurnoverWait() => new WebDriverWait(App_Drivers.Driver, new TimeSpan(0, 0, 25));

        #region Elements

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[4]/div/div[1]/div/a[1]/img")] private IWebElement Tshirt;
        [FindsBy(How = How.XPath, Using = "//*[@id='header_logo']/a/img")] private IWebElement Logo;

        [FindsBy(How = How.XPath, Using = "//*[@id='quantity_wanted_p']/a[2]/span/i")] private IWebElement quan;
        [FindsBy(How = How.Id, Using = "add_to_cart")] private IWebElement Chart;

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")] private IWebElement checkout;
        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/p[2]/a[1]")] private IWebElement proceed;

        #endregion
        public void Navgiate_to_YourLogo_page()
        {
            var Yourlogo = ConfigurationManager.AppSettings["BaseUrl"];
            App_Drivers.Driver.Navigate().GoToUrl(Yourlogo);
        }


        public void Click_on_Tshirt()
        {
            try
            {
                Tshirt.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }

        public void Click_on_Logo()
        {
            try
            {
                Logo.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }

        public void Click_on_quantity()
        {
            try
            {
                quan.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }

        public void Click_on_Add_to_chart()
        {
            try
            {
                Chart.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }

        }

        public void Click_on_Checkout()
        {
            try
            {
                checkout.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }


        public void Click_on_procees_to_checkout()
        {
            try
            {
                proceed.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }

        #region BrowserCalls
        public void back()
        {
            App_Drivers.Driver.Navigate().Back();
        }
        public void Maximise()
        {
            App_Drivers.Driver.Manage().Window.Maximize();
        }
        #endregion



    }
}