using Aquality.Selenium.Browsers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Userinterface.Configurations;
using Userinterface.Forms.Pages;

namespace Userinterface.SpecFlow.StepDefinitions.UI
{
    [Binding]
    public class MainPageSteps
    {
        private readonly HomePage homePage = new HomePage();


        [Given(@"I navigate to home page")]
        public static void INavigateToHomePage()
        {
            AqualityServices.Browser.GoTo(Configuration.StartUrl);
        }

        [Then(@"Home page is opened")]
        public void HomePageIsOpened()
        {
            Assert.IsTrue(homePage.State.WaitForDisplayed(), "Home page should be opened");
        }

        [When(@"I click the next page link")]
        public void IClickTheNextPageLink()
        {
            homePage.ClickNextPageLink();
        }
    }
}