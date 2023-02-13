using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Userinterface.Forms.Pages
{
    public class GamePage : Aquality.Selenium.Forms.Form
    {
        private ILabel CardNumIndicatorLbl => ElementFactory.GetLabel(By.XPath("//*[@class='page-indicator']"), nameof(CardNumIndicatorLbl));
        private ILabel TimerLbl => ElementFactory.GetLabel(By.XPath("//*[contains(@class,'time')]"), nameof(TimerLbl));

        public GamePage() : base(By.XPath("//ul[contains(@class,'pagination')]"), nameof(GamePage))
        {
        }

        public char GetCardNum()
        {
            return CardNumIndicatorLbl.Text[0];
        }

        public string GetTimerValue()
        {
            return TimerLbl.Text;
        }
    }
}