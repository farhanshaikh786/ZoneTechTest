using OpenQA.Selenium.Chrome;
using System.Configuration;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using ZoneTest_Project.Helpers;
using ZoneTest_Project.PO;

namespace ZoneTest_Project.Helpers
{
    [Binding]
    public class DriverHook
    {
        public static string baseurl = ConfigurationManager.AppSettings["BaseUrl"];

        Order home = new Order();

        [BeforeFeature()]
        public static void BeforeScenario()
        {

            
            App_Drivers.Driver = new ChromeDriver();
            //App_Drivers.Driver = new EdgeDriver();
            //App_Drivers.Driver = new InternetExplorerDriver();
            //App_Drivers.Driver = new FirefoxDriver();
            App_Drivers.Driver.Navigate().GoToUrl(baseurl);



        }

        [BeforeScenario]
        public void before()
        {
            home.Maximise();
        }

        [AfterFeature()]

        public static void AfterScenario()
        {
            App_Drivers.Driver.Quit();

        }
    }
}
