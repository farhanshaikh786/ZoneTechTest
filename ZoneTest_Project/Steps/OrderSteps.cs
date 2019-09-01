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
        
        
        [When(@"Client one more quantity")]
        public void WhenClientOneMoreQuantity()
        {
            order.Click_on_quantity();
        }
        
        [When(@"Client on Add Chart")]
        public void WhenClientOnAddChart()
        {
            order.Click_on_Add_to_chart();
        }
        
        [When(@"Client proceed to checkout")]
        public void WhenClientProceedToCheckout()
        {
            order.Click_on_Checkout();
        }

        
        [Then(@"Client to checkout")]
        public void ThenClientToCheckout()
        {
            order.Click_on_procees_to_checkout();
        }
    }
}
