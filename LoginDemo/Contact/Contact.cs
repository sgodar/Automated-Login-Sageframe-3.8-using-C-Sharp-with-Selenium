using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemo.Contact
{
    class Contact
    {
        IWebDriver driver = null;
        public Contact()
        {
            driver = new FirefoxDriver();

        }

        public void Contactus()
        {

            driver.Url = "http://localhost:8099Contact";
            var Name = driver.FindElement(By.Id("lytA_ctl23_txtName"));
            var Email = driver.FindElement(By.Id("lytA_ctl23_txtContactEmail"));
            var Message = driver.FindElement(By.Id("lytA_ctl23_txtMessage"));
            var Captcha = driver.FindElement(By.Id("lytA_ctl23_Label1"));
            var captchasend = driver.FindElement(By.Id("lytA_ctl23_txtCaptchaSUM"));
            var Submit = driver.FindElement(By.Id("lytA_ctl23_btnSubmit"));
            String x = driver.FindElement(By.CssSelector(".captcha-math > span:nth-child(2)")).Text;
            String y = driver.FindElement(By.CssSelector(".captcha-math > span:nth-child(4)")).Text;
            //String x = driver.FindElement(By.XPath(".//*[@id='lytA_ctl23_Label1']/span[1]")).Text;
            // String y = driver.FindElement(By.XPath(".//*[@id='lytA_ctl23_Label1']/span[2]")).Text;
            int a = int.Parse(x);
            int b = int.Parse(y);
            int c = a + b;
            string d = c.ToString();


            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            string email = result + "@gmail.com";
            Name.Click();
            Name.Clear();
            Name.SendKeys("SUNIl");
            Email.Click();
            Email.Clear();
            Email.SendKeys(email);
            Message.SendKeys("Hello");
            captchasend.Click();
            captchasend.Clear();
            captchasend.SendKeys(d);
            Submit.Click();
           // driver.Manage().Cookies.DeleteAllCookies();

        }
    }
}
