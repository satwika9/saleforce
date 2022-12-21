using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalesForce.Drivers
{
   public class class1
    {
        public IWebDriver driver;

        
        public void navigate()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.salesforce.com/in/?ir=1");
            driver.Manage().Window.Maximize();



          

        }
    }



}
