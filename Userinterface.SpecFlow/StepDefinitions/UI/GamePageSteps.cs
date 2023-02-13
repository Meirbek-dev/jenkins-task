using NUnit.Framework;
using TechTalk.SpecFlow;
using Userinterface.Forms;
using Userinterface.Forms.Pages;
using Userinterface.Models;
using Userinterface.SpecFlow.Resources.Constants;

namespace Userinterface.SpecFlow.StepDefinitions.UI
{
    [Binding]
    public class GamePageSteps
    {
        private readonly GamePage gamePage = new GamePage();
        private readonly CookiesForm cookiesForm;
        private readonly HelpForm helpForm;
        private readonly FirstCard firstCard;
        private readonly SecondCard secondCard;


        public GamePageSteps(CookiesForm cookiesForm, HelpForm helpForm, FirstCard firstCard, SecondCard secondCard)
        {
            this.cookiesForm = cookiesForm;
            this.helpForm = helpForm;
            this.firstCard = firstCard;
            this.secondCard = secondCard;
        }

        [When(@"I register random user")]
        public void IRegisterRandomUser()
        {
            firstCard.RegisterUser(new RandomUser());
        }

        [When(@"I click Next button on the first card")]
        public void IClickNextButtonoOnTheFirstCard()
        {
            firstCard.ClickFirstCardNextBtn();
        }

        [When(@"I unselect all interests")]
        public void IUnselectAllInterests()
        {
            secondCard.ClickUnselectAll();
        }

        [When(@"I select '(.*)' random interests")]
        public void ISelectRandomInterests(int numOfInterests)
        {
            secondCard.SelectRandomInterests(numOfInterests);
        }

        [When(@"I upload an image")]
        public void IUploadAnImage()
        {
            secondCard.UploadAnImage(Constants.avatarFileName);
        }

        [When(@"I click Next button on the second card")]
        public void IClickNextButtonOnTheSecondCard()
        {
            secondCard.ClickSecondCardNextButton();
        }

        [When(@"I hide help form")]
        public void IHideHelpForm()
        {
            helpForm.SendHelpFormToBottom();
        }

        [When(@"I accept Cookies")]
        public void IAcceptCookiesPolicy()
        {
            cookiesForm.AcceptCookies();
        }

        [Then(@"Game page is opened")]
        public void GamePageIsOpened()
        {
            Assert.IsTrue(gamePage.State.WaitForDisplayed(), "Game page must be opened");
        }

        [Then(@"Card '(\d)' is open")]
        public void ThenCardIsOpen(char expectedCardNum)
        {
            Assert.IsTrue(gamePage.GetCardNum() == expectedCardNum, $"Card #{expectedCardNum} must be opened");
        }

        [Then(@"Help form content is hidden")]
        public void ThenHelpFormContentIsHidden()
        {
            Assert.IsTrue(helpForm.ContentIsHidden, "Help form content must be hidden");
        }

        [Then(@"Cookies form is closed")]
        public void ThenCookiesFormIsClosed()
        {
            Assert.IsTrue(cookiesForm.IsClosed, "Cookies form must be closed");
        }

        [Then(@"Timer starts at '(\d\d:\d\d:\d\d)'")]
        public void ThenTimerStartsFrom(string timerStartValue)
        {
            Assert.IsTrue(gamePage.GetTimerValue() == timerStartValue, $"Timer must start at {timerStartValue}");
        }
    }
}