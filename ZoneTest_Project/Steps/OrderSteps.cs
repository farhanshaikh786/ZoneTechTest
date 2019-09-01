using System;
using System.Threading;
using TechTalk.SpecFlow;
using ZoneTest_Project.PO;

namespace ZoneTest_Project
{
    [Binding]
    public class OrderSteps
    {

        Order order = new Order();


        [Given(@"Client is navigated to Your logo page")]
        public void GivenClientIsNavigatedToYourLogoPage()
        {
            order.Navgiate_to_YourLogo_page();
        }
        
        
        [When(@"Client select T-shirt link")]
        public void WhenClientSelectT_ShirtLink()
        {
            order.Click_on_Tshirt();
        }

        [Then(@"Client returns back to Your logo page")]
        public void ThenClientReturnsBackToYourLogoPage()
        {
            order.Click_on_Logo();
        }

        [When(@"Client click on Printed Dress")]
        public void WhenClientClickOnPrintedDress()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            order.Click_on_Printed_dress();
        }

        
        [When(@"Client on Add Chart")]
        public void WhenClientOnAddChart()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            order.Click_on_Add_to_chart();
        }
        
        [When(@"Client proceed to checkout")]
        public void WhenClientProceedToCheckout()
        {
            order.Click_on_Checkout();
        }

        [When(@"Client to checkout")]
        public void WhenClientToCheckout()
        {
            order.Click_on_procees_to_checkout();
        }

        [When(@"Client entered the ""(.*)""")]
        public void WhenClientEnteredThe(string p0)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            order.Click_Email_Address(p0);
        }

        [When(@"Client clicked on login button")]
        public void WhenClientClickedOnLoginButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            order.Click_on_create_account();
        }

        [When(@"Client click Mr on title")]
        public void WhenClientClickMrOnTitle()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            order.Click_on_Gender();
        }

        [When(@"Client enters ""(.*)""")]
        public void WhenClientEnters(string p0)
        {
            order.Click_First_name(p0);
        }

        [When(@"Client could also add ""(.*)""")]
        public void WhenClientCouldAlsoAdd(string p0)
        {
            order.Click_Last_name(p0);
        }

        [When(@"Client must add ""(.*)""")]
        public void WhenClientMustAdd(string p0)
        {
            order.Click_Email_address(p0);
        }

        [When(@"Client needs to ""(.*)""")]
        public void WhenClientNeedsTo(string p0)
        {
            order.Click_Password(p0);
        }

        [When(@"Client enters again ""(.*)""")]
        public void WhenClientEntersAgain(string p0)
        {
            order.Click_First_Name(p0);
        }

        [When(@"Client could also add again ""(.*)""")]
        public void WhenClientCouldAlsoAddAgain(string p0)
        {
            order.Click_Last_Name(p0);
        }

        [When(@"Client also ""(.*)""")]
        public void WhenClientAlso(string p0)
        {
            order.Click_Address(p0);
        }

        [When(@"the Client ""(.*)""")]
        public void WhenTheClient(string p0)
        {
            order.Click_City(p0);
        }

        [When(@"Client fills in ""(.*)""")]
        public void WhenClientFillsIn(string p0)
        {
            order.Click_State(p0);
        }

        [When(@"Client adds the ""(.*)""")]
        public void WhenClientAddsThe(string p0)
        {
            order.Click_Zip_Postal_code(p0);
        }

        [When(@"Client ""(.*)""")]
        public void WhenClient(string p0)
        {
            order.Click_Country(p0);
        }

        [When(@"Client will select ""(.*)""")]
        public void WhenClientWillSelect(string p0)
        {
            order.Click_Mobile_Phone(p0);
        }

        [When(@"Client remember ""(.*)""")]
        public void WhenClientRemember(string p0)
        {
            order.Click_Assign_An_Address(p0);
        }





    }
}
