using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Linq;

namespace CaptchaDemo
{
    class Login
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://localhost:9000/Contact.aspx";
            var Name = driver.FindElement(By.Id("lytA_ctl23_txtName"));
            Name.SendKeys("Sunil");
            var Email = driver.FindElement(By.Id("lytA_ctl23_txtContactEmail"));
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8) //using linq for Enumerable
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            string email = result + "@gmail.com";
            Email.SendKeys(email);
            var Message = driver.FindElement(By.Id("lytA_ctl23_txtMessage"));
            Message.SendKeys("This text is for demo purpose");
            var Captcha = driver.FindElement(By.Id("lytA_ctl23_txtCaptchaSUM"));
            String x = driver.FindElement(By.XPath("//*[@id='center1']/div[1]/div[1]/div/div/div/div/div[5]/label/span[2]")).Text;
            String y = driver.FindElement(By.XPath("//*[@id='center1']/div[1]/div[1]/div/div/div/div/div[5]/label/span[4]")).Text;
            int a = Int32.Parse(x);
            int b = Int32.Parse(y);
            string Sum = (a+b).ToString();
            Captcha.SendKeys(Sum);
            driver.FindElement(By.Id("lytA_ctl23_btnSubmit")).Click();
            //Submit.Click();


        }
    }
}
