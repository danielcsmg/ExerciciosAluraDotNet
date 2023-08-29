using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    internal class MenuMobilePO
    {
        private ChromeDriver driver;
        private By byMenuMobile;

        public MenuMobilePO(ChromeDriver driver)
        {
            this.driver = driver;
            byMenuMobile = By.ClassName("sidenav-trigger");
        }

        public bool MenuMobileVisivel {
            get
            {
                var elemento = driver.FindElement(byMenuMobile);
                return elemento.Displayed;
            }
        }
    }
}