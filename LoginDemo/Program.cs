using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using LoginDemo.Login;
using LoginDemo.Contact;

namespace LoginDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            calllogin();
            // callcontact();
        }

        static void calllogin()
        {
            Login.Login objlogin = new Login.Login();
            objlogin.Userlogin();
        }
        static void callcontact()
        {
            Contact.Contact objcontact = new Contact.Contact();
            objcontact.Contactus();
        }
    }
}
