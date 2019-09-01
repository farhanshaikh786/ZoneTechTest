using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ZoneTest_Project.Helpers;

namespace ZoneTest_Project.PO
{
    public class CreateAccount
    {
        public CreateAccount()
        
        {
            PageFactory.InitElements(App_Drivers.Driver, this);
        }
            Actions _actions = new Actions(App_Drivers.Driver);

            public void TurnoverWait() => new WebDriverWait(App_Drivers.Driver, new TimeSpan(0, 0, 25));

        #region Elements

        [FindsBy(How = How.XPath, Using = "//*[@id='header']/div[2]/div/div/nav/div[1]/a")] private IWebElement Log;
        [FindsBy(How = How.XPath, Using = "//*[@id='email_create']")] private IWebElement emailadd;
        [FindsBy(How = How.XPath, Using = "//*[@id='SubmitCreate']")] private IWebElement create;

        [FindsBy(How = How.Id, Using = "id_gender1")] private IWebElement gender;
        [FindsBy(How = How.Id, Using = "customer_firstname")] private IWebElement First;

        [FindsBy(How = How.Id, Using = "customer_lastname")] private IWebElement Last;
        [FindsBy(How = How.Id, Using = "email")] private IWebElement mail;

        [FindsBy(How = How.Id, Using = "passwd")] private IWebElement Pass;
        [FindsBy(How = How.Id, Using = "firstname")] private IWebElement FN;

        [FindsBy(How = How.Id, Using = "lastname")] private IWebElement LN;
        [FindsBy(How = How.Id, Using = "address1")] private IWebElement adress;

        [FindsBy(How = How.Id, Using = "city")] private IWebElement city;
        [FindsBy(How = How.Id, Using = "id_state")] private IWebElement state;

        [FindsBy(How = How.Id, Using = "postcode")] private IWebElement Postcode;
        [FindsBy(How = How.Id, Using = "id_country")] private IWebElement country;

        [FindsBy(How = How.Id, Using = "phone_mobile")] private IWebElement mobile;
        [FindsBy(How = How.Id, Using = "alias")] private IWebElement assign;
        [FindsBy(How = How.Id, Using = "submitAccount")] private IWebElement submit;

        #endregion


        public void Navgiate_to_YourLogo_page()
        {
            var Yourlogo = ConfigurationManager.AppSettings["BaseUrl"];
            App_Drivers.Driver.Navigate().GoToUrl(Yourlogo);
        }

        public void Click_on_sign_in()
        {
            try
            {
                Log.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }
        public void Click_Email_Address(string email)
        {
            try
            {
                emailadd.SendKeys(email);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_on_create_account()
        {
            try
            {
                create.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }

        public void Click_on_Gender()
        {
            try
            {
                gender.Click();
            }
            catch (Exception e)
            {
                throw new Exception("No Element found", e);
            }
        }
        public void Click_First_name(string name)
        {
            try
            {
                First.SendKeys(name);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Last_name(string last)
        {
            try
            {
                Last.SendKeys(last);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }

        public void Click_Email_address(string Email)
        {
            try
            {
                mail.SendKeys(Email);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Password(string password)
        {
            try
            {
                Pass.SendKeys(password);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_First_Name(string First)
        {
            try
            {
                FN.SendKeys(First);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }

        public void Click_Last_Name(string Last)
        {
            try
            {
                LN.SendKeys(Last);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Address(string add)
        {
            try
            {
                adress.SendKeys(add);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_City(string cities)
        {
            try
            {
                city.SendKeys(cities);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_State(string stateadd)
        {
            try
            {
                state.SendKeys(stateadd);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }

        public void Click_Zip_Postal_code(string Zip)
        {
            try
            {
                Postcode.SendKeys(Zip);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Country(string cou)
        {
            try
            {
                country.SendKeys(cou);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Mobile_Phone(string phone)
        {
            try
            {
                mobile.SendKeys(phone);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_Assign_An_Address(string assig)
        {
            try
            {
                assign.SendKeys(assig);
            }
            catch (Exception e)
            {

                throw new ElementNotVisibleException("Can't found element", e);
            }

        }
        public void Click_on_Register()
        {
            try
            {
                submit.Click();
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
