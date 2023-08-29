﻿using System;
using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoOfertarLance
    {
        private IWebDriver driver;
        public AoOfertarLance(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoLoginInteressadaDeveAtualizarLanceAtual()
        {
            //arrange
            var loginPO = new LoginPO(driver);
            loginPO.Visitar();
            loginPO.PreencheFormulario("fulano@example.org", "123");
            loginPO.SubmeteFormulario();

            var detalheLeilaoPO = new DetalheLeilaoPO(driver);

            detalheLeilaoPO.Visitar(2);

            //act
            detalheLeilaoPO.OfertarLance(200.00);

            //assert
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));

            bool iguais = wait.Until(dvr => detalheLeilaoPO.LanceAtual == 200);

            Assert.True(iguais);
        }
    }
}
