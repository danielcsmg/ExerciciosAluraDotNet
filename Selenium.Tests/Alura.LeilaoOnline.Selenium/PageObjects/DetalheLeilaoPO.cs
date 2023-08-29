using System;
using System.Threading;
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class DetalheLeilaoPO
    {
        private IWebDriver driver;
        private By byInputValor;
        private By byLanceAtual;
        private By byBtnLance;

        public DetalheLeilaoPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputValor = By.Name("Valor");
            byLanceAtual = By.Id("lanceAtual");
            byBtnLance = By.Id("btnDarLance");
        }

        public double LanceAtual
        {
            get
            {
                var valorTexto = driver.FindElement(byLanceAtual).Text;
                var valor = double.Parse(valorTexto, System.Globalization.NumberStyles.Currency);
                return valor;
            }
        }

        public void Visitar(int idLeilao)
        {
            driver.Navigate().GoToUrl($"http://localhost:5000/Home/Detalhes/{idLeilao}");
        }

        public void OfertarLance(double valor)
        {
            var campoLance = driver.FindElement(byInputValor);
            campoLance.Clear();
            campoLance.SendKeys(valor.ToString());
            driver.FindElement(byBtnLance).Click();
        }
    }
}