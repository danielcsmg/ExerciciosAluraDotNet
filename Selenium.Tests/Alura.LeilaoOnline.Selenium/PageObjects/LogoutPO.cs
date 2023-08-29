using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class LogoutPO
    {
        private IWebDriver driver;
        private By byLogoutLink;
        private By byMenuLink;

        public LogoutPO(IWebDriver driver)
        {
            this.driver = driver;
            byLogoutLink = By.Id("logout");
            byMenuLink = By.Id("meu-perfil");
        }


        public void EfetuarLogout()
        {
            var linkMenu = driver.FindElement(byMenuLink);
            var linkLogout = driver.FindElement(byLogoutLink);

            IAction logout = new Actions(driver)
                .MoveToElement(linkMenu)
                .MoveToElement(linkLogout)
                .Click()
                .Build();

            logout.Perform();
        }
    }
}
