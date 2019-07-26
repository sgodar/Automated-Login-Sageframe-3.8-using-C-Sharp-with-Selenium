using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo.Login

{
    class Login
    {
        IWebDriver driver = null;
        public Login()
        {
            driver = new FirefoxDriver();
            
        }
       public void Userlogin()
        {
            driver.Url = "http://localhost:8099/sf/sfLogin.aspx";
            var UserName = driver.FindElement(By.Id("ctl16_UserName"));
            var Password = driver.FindElement(By.Id("ctl16_Password"));
            var SignIn = driver.FindElement(By.Id("ctl16_LoginButton"));

                UserName.Click();
                UserName.Clear();
                UserName.SendKeys("Superuser");
                Password.Click();
                Password.Clear();
                Password.SendKeys("superuser");
                SignIn.Click();
        }
    
    }
}
