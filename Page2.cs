using OpenQA.Selenium;
using SalesForce.Drivers;
using SeleniumExtras.PageObjects;


namespace SalesForce.Page
{
    public class page2
    {

        public page2(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "/html/body/footer/div/div[1]/div/div/div/div/div/div[3]/div[2]/ul/li[5]/span/a")]
        public IWebElement SP { get; set; }


       

    }
}






