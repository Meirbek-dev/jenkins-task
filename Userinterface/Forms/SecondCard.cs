using Aquality.Selenium.Elements.Interfaces;
using OpenQA.Selenium;
using System.Collections.Generic;
using Userinterface.Utilities;

namespace Userinterface.Forms
{
    public class SecondCard : Aquality.Selenium.Forms.Form
    {

        public const int selectAllChbx = 17;

        private ICheckBox UnselectAllChbx => ElementFactory.GetCheckBox(By.XPath("//input[@id='interest_unselectall']/following::span"), nameof(UnselectAllChbx));
        private IButton UploadBtn => ElementFactory.GetButton(By.XPath("//a[text()='upload']"), nameof(UploadBtn));
        private IButton SecondCardNextBtn => ElementFactory.GetButton(By.XPath("//button[text()='Next']"), nameof(SecondCardNextBtn));

        private ICheckBox InterestChbx(int checkBoxNum) => ElementFactory.GetCheckBox(By.XPath($"//span[@class='checkbox small']/following::span[@class='checkbox__box'][{checkBoxNum}]"), $"CheckBox #{checkBoxNum}");

        public SecondCard() : base(By.ClassName("avatar-and-interests__form"), nameof(SecondCard))
        {
        }

        public void ClickUnselectAll()
        {
            UnselectAllChbx.Click();
        }

        public void SelectRandomInterests(int numOfInterestsToSelect)
        {
            var clickedInterest = new List<int>();
            for (int i = 1; i < numOfInterestsToSelect + 1; i++)
            {
                int randomInterest = Randomizer.GetInt();
                if (randomInterest == selectAllChbx || clickedInterest.Contains(randomInterest))
                {
                    --i;
                    continue;
                }
                InterestChbx(randomInterest).Click();
                clickedInterest.Add(randomInterest);
            }
        }

        public void ClickUploadButton()
        {
            UploadBtn.Click();
        }

        public void UploadAnImage(string PathToImage)
        {
            ClickUploadButton();
            UploadFileUtil.UploadFile(PathToImage);
        }

        public void ClickSecondCardNextButton()
        {
            SecondCardNextBtn.Click();
        }
    }
}