using System;
using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaHomeMobile : IDisposable
    {
        private ChromeDriver driver;

        [Fact]
        public void DadaLargura992DeveMostrarMenuMobile()
        {
            var deviceSettings = new ChromiumMobileEmulationDeviceSettings();
            deviceSettings.Width = 992;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);
            driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            //arrange
            var homePO = new HomeNaoLogadaPO(driver);

            //act
            homePO.Visitar();

            //assert
            Assert.True(homePO.Menu.MenuMobileVisivel);

        }

        [Fact]
        public void DadaLargura993DeveMostrarMenuNormal()
        {
            var deviceSettings = new ChromiumMobileEmulationDeviceSettings();
            deviceSettings.Width = 993;
            deviceSettings.Height = 800;
            deviceSettings.UserAgent = "Customizada";
            var options = new ChromeOptions();
            options.EnableMobileEmulation(deviceSettings);
            driver = new ChromeDriver(TestHelper.PastaDoExecutavel, options);
            //arrange
            var homePO = new HomeNaoLogadaPO(driver);

            //act
            homePO.Visitar();

            //assert
            Assert.False(homePO.Menu.MenuMobileVisivel);

        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
