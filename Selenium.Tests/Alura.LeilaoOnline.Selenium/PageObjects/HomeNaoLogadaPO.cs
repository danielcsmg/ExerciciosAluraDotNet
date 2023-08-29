using System;
using OpenQA.Selenium.Chrome;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    internal class HomeNaoLogadaPO
    {
        private ChromeDriver driver;
        public MenuMobilePO Menu;

        public HomeNaoLogadaPO(ChromeDriver driver)
        {
            this.driver = driver;
            Menu = new MenuMobilePO(driver);
        }

        internal void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000");
        }
    }
}