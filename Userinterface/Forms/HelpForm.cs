using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;

namespace Userinterface.Forms.Pages
{
    public class HelpForm : Aquality.Selenium.Forms.Form
    {
        private IButton SendHelpFormToBottomBtn => ElementFactory.GetButton(By.XPath("//button[contains(@class,'help-form__send-to-bottom-button')]"), nameof(SendHelpFormToBottomBtn));
        private ITextBox HelpFormContent => ElementFactory.GetTextBox(By.ClassName("help-form__text-area"), nameof(HelpFormContent));

        public HelpForm() : base(By.ClassName("help-form__container"), nameof(HelpForm))
        {
        }

        public bool ContentIsHidden => HelpFormContent.State.WaitForNotDisplayed();

        public void SendHelpFormToBottom()
        {
            SendHelpFormToBottomBtn.Click();
        }
    }
}