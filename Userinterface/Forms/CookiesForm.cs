using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Userinterface.Forms.Pages
{
    public class CookiesForm : Aquality.Selenium.Forms.Form
    {
        private IButton AcceptCookiesBtn => ElementFactory.GetButton(By.XPath("//button[text()='Not really, no']"), nameof(AcceptCookiesBtn));

        public CookiesForm() : base(By.XPath("//div[@class='cookies']"), nameof(CookiesForm))
        {
        }

        public bool IsClosed => this.State.WaitForNotDisplayed();

        public void AcceptCookies()
        {
            AcceptCookiesBtn.Click();
        }
    }
}