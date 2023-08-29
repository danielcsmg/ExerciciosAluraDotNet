using System.Collections.Generic;
using OpenQA.Selenium;

namespace Alura.ByteBank.WebApp.Testes.PageObjects
{
    public class LoginPO
    {
        private IWebDriver _driver;
        private By campoEmail;
        private By campoSenha;
        private By btnLogar;

        public LoginPO(IWebDriver driver)
        {
            this._driver = driver;
            campoEmail = By.Id("Email");
            campoSenha = By.Id("Senha");
            btnLogar = By.Id("btn-logar");
        }

        public void Navegar(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void IrParaAPagina(string endpoint)
        {
            _driver.FindElement(By.LinkText(endpoint)).Click();
        }

        public void PreencherCampos(string email, string senha)
        {
            _driver.FindElement(campoEmail).SendKeys(email);
            _driver.FindElement(campoSenha).SendKeys(senha);
        }

        public void ClicarNoElemento(string nomeBtn)
        {
            var elemento = _driver.FindElement(By.Id(nomeBtn));
            elemento.Click();
        }

        public void BtnClickLogin()
        {
            var elemento = _driver.FindElement(btnLogar);
                elemento.Click();
        }

        public IWebElement GetElement(By element)
        {
            return _driver.FindElement(element);
        }
        
        public string GetPageSource()
        {
            return _driver.PageSource;
        }
        
        public string GetUrl()
        {
            return _driver.Url;
        }
        
        public IReadOnlyCollection<IWebElement> GetElementsByTagName(string tag)
        {
            return _driver.FindElements(By.TagName(tag));
        }

        public void Close()
        {
            _driver.Close();
        }
    }
}
