using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using Userinterface.Models;

namespace Userinterface.Forms
{
    public class FirstCard : Aquality.Selenium.Forms.Form
    {
        private ITextBox PasswordTxb => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Choose Password')]"), nameof(PasswordTxb));
        private ITextBox EmailTxb => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Your email')]"), nameof(EmailTxb));
        private ITextBox DomainTxb => ElementFactory.GetTextBox(By.XPath("//input[contains(@placeholder,'Domain')]"), nameof(DomainTxb));
        private ICheckBox TermsAndConditionsChbx => ElementFactory.GetCheckBox(By.XPath("//*[contains(@class,'checkbox__check')]"), nameof(TermsAndConditionsChbx));
        private IButton FirstCardNextBtn => ElementFactory.GetButton(By.XPath("//a[text()='Next']"), nameof(FirstCardNextBtn));
        private IComboBox EmailTopLevelDomainCmbx => ElementFactory.GetComboBox(By.ClassName("dropdown__opener"), nameof(EmailTopLevelDomainCmbx));

        private IComboBox DesiredEmailTopLevelDomainItem(string desiredEmailTopLevelDomain) => ElementFactory.GetComboBox(By.XPath($"//*[text()='{desiredEmailTopLevelDomain}']"), $"Email top level domain: {desiredEmailTopLevelDomain}");

        public FirstCard() : base(By.ClassName("login-form__container"), nameof(FirstCard))
        {
        }

        public void SetPassword(string password)
        {
            PasswordTxb.ClearAndType(password);
        }

        public void SetEmailUsername(string email)
        {
            EmailTxb.ClearAndType(email);
        }

        public void SetEmailDomain(string domain)
        {
            DomainTxb.ClearAndType(domain);
        }

        public void ClickEmailTopLevelDomainCmbx()
        {
            EmailTopLevelDomainCmbx.Click();
        }

        public void SelectEmailTopLevelDomain(string emailTopLevelDomain)
        {
            ClickEmailTopLevelDomainCmbx();
            DesiredEmailTopLevelDomainItem(emailTopLevelDomain).Click();
        }

        public void AcceptTermsAndConditions()
        {
            TermsAndConditionsChbx.Click();
        }

        public void RegisterUser(RandomUser user)
        {
            SetPassword(user.Password);
            SetEmailUsername(user.EmailUsername);
            SetEmailDomain(user.EmailDomain);
            SelectEmailTopLevelDomain(user.EmailTopLevelDomain);
            AcceptTermsAndConditions();
        }

        public void ClickFirstCardNextBtn()
        {
            FirstCardNextBtn.Click();
        }
    }
}