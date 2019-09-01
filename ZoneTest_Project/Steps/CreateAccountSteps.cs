using System;
using System.Threading;
using TechTalk.SpecFlow;
using ZoneTest_Project.PO;

namespace ZoneTest_Project.Steps
{
    [Binding]
    public class CreateAccountSteps
    {
        CreateAccount account = new CreateAccount();

        [Given(@"Client is navigated to Yourlogo Site page")]
        public void GivenClientIsNavigatedToYourlogoSitePage()
        {
            account.Navgiate_to_YourLogo_page();
        }

        [Given(@"Client is click on Sign In")]
        public void GivenClientIsClickOnSignIn()
        {
            account.Click_on_sign_in();
        }


        [Given(@"Client entered the ""(.*)""")]
        public void GivenClientEnteredThe(string p0)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            account.Click_Email_Address(p0);
        }


        [Given(@"Client clicked on login button")]
        public void GivenClientClickedOnLoginButton()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            account.Click_on_create_account();
        }
        
        [Given(@"Client click Mr on title")]
        public void GivenClientClickMrOnTitle()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            account.Click_on_Gender();
        }
        
        [Given(@"Client enters ""(.*)""")]
        public void GivenClientEnters(string p0)
        {
            account.Click_First_name(p0);
        }
        
        [Given(@"Client could also add ""(.*)""")]
        public void GivenClientCouldAlsoAdd(string p0)
        {
            account.Click_Last_name(p0);
        }
        
        [Given(@"Client must add ""(.*)""")]
        public void GivenClientMustAdd(string p0)
        {
            account.Click_Email_address(p0);
        }
        
        [Given(@"Client needs to ""(.*)""")]
        public void GivenClientNeedsTo(string p0)
        {
            account.Click_Password(p0);
        }
        
        [Given(@"Client enters again ""(.*)""")]
        public void GivenClientEntersAgain(string p0)
        {
            account.Click_First_Name(p0);
        }
        
        [Given(@"Client could also add again ""(.*)""")]
        public void GivenClientCouldAlsoAddAgain(string p0)
        {
            account.Click_Last_Name(p0);
        }
        
        [Given(@"Client also ""(.*)""")]
        public void GivenClientAlso(string p0)
        {
            account.Click_Address(p0);
        }
        
        [Given(@"the Client ""(.*)""")]
        public void GivenTheClient(string p0)
        {
            account.Click_City(p0);
        }
        
        [Given(@"Client fills in ""(.*)""")]
        public void GivenClientFillsIn(string p0)
        {
            account.Click_State(p0);
        }
        
        [Given(@"Client adds the ""(.*)""")]
        public void GivenClientAddsThe(string p0)
        {
            account.Click_Zip_Postal_code(p0);
        }
        
        [Given(@"Client ""(.*)""")]
        public void GivenClient(string p0)
        {
            account.Click_Country(p0);
        }
        
        [Given(@"Client will select ""(.*)""")]
        public void GivenClientWillSelect(string p0)
        {
            account.Click_Mobile_Phone(p0);
        }
        
        [Given(@"Client remember ""(.*)""")]
        public void GivenClientRemember(string p0)
        {
            account.Click_Assign_An_Address(p0);
        }
    
        
        [Then(@"Submit the Full form")]
        public void ThenSubmitTheFullForm()
        {
            account.Click_on_Register();
        }

        [Then(@"Client returns back to Home page")]
        public void ThenClientReturnsBackToHomePage()
        {
            account.Navgiate_to_YourLogo_page();
        }
    }
}
