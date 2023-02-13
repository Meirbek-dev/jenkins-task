using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Userinterface.Forms.Pages
{
    public class HomePage : Aquality.Selenium.Forms.Form
    {
        private ILink NextPageLink => ElementFactory.GetLink(By.ClassName("start__link"), nameof(NextPageLink));

        public HomePage() : base(By.XPath("//*[contains(@class,'start')]"), nameof(HomePage))
        {
        }

        public void ClickNextPageLink()
        {
            NextPageLink.Click();
        }
    }
}