using OpenQA.Selenium;
using SalesForce.Drivers;
using SeleniumExtras.PageObjects;


namespace SalesForce.Page
{
    public class page1 
    {

        public page1(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div[2]/div/div/div/div[2]/div[1]/div[1]/div[2]/div/span/a")]
        public IWebElement seemore { get; set; }

       [FindsBy(How = How.XPath, Using = "/html/body/footer/div/div[2]/div/div/div/div/div[2]/nav/ul/li[6]/a")]
       public IWebElement contact { get ; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/footer/div/div[1]/div/div/div/div/div/div[3]/div[2]/ul/li[5]/span/a")]
        public IWebElement SP { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"__next\"]/div/main/div[3]/div[1]/div[1]/wes-card/a")]
        public IWebElement status { get; set; }

       



        /* [FindsBy(How = How.Id, Using = "UserFirstName")]
         public IWebElement firstname { get; set; }

         [FindsBy(How = How.Id, Using = "UserLastName")]
         public IWebElement lastname { get; set; }*/


        // driver.FindElement(By.XPath("//*[@id=\"main\"]/div[1]/div/div[6]/div[1]/div[1]/div/div/div[2]")).Click();

    }
}





       
