using OpenQA.Selenium.Interactions;
using SalesForce.Drivers;
using SalesForce.Page;
using System;
using System.Security.AccessControl;
using TechTalk.SpecFlow;

namespace SalesForce.StepDefinitions
{
    [Binding]
    public class Page1StepDefinitions: class1
    {
        [Given(@"should navigate to url")]
        public void GivenShouldNavigateToUrl()
        {
            navigate();
        }

        [When(@"I click see more")]
        public void WhenIClickSeeMore()
        {
            page1 sm = new page1(driver);

            sm.seemore.Click();
            Thread.Sleep(1000);
         
        }

        [Then(@"should display the see more page")]
        public void ThenShouldDisplayTheSeeMorePage()
        {
            driver.Navigate().Back();

            Thread.Sleep(1000);
            driver.Quit();

        }


        [Given(@"should navigate to the url")]
        public void GivenShouldNavigateToTheUrl()
        {
            navigate();

        }

        [When(@"scroll down")]
        public void WhenScrollDown()
        {
            Actions act = new Actions(driver);

            act.Click();

            act.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();

            Thread.Sleep(1000);
        }

        [When(@"click on security and performance")]
        public void WhenClickOnSecurityAndPerformance()
        {
            page2 SecPer = new (driver);
            SecPer.SP.Click();
            Thread.Sleep(1000);
        }

        [Then(@"should display the page")]
        public void ThenShouldDisplayThePage()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(10000);
            driver.Quit();
            
        }


        [Given(@"should navigate to  url")]
        public void GivenShouldNavigateUrl()
        {
           navigate();
        }

        [When(@"scroll down the page")]
        public void WhenScrollDownThePage()
        {
            Actions a = new Actions(driver);
            a.Click();
            a.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
            Thread.Sleep(1000);
        }

        [When(@"click on cookie preference")]
        public void WhenClickOnCookiePreference()
        {
            page3 cp = new(driver);
            cp.CP.Click();
            Thread.Sleep(1000);
        }

        [When(@"accept the cookie")]
        public void WhenAcceptTheCookie()
        {
            throw new PendingStepException();
        }

        [Then(@"navigate to home page")]
        public void ThenNavigateToHomePage()
        {
            throw new PendingStepException();
        }






    }

}
