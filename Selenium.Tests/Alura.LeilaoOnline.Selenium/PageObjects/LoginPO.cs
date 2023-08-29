﻿using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class LoginPO
    {
        private IWebDriver driver;
        private By byInputLogin;
        private By byInputSenha;
        private By byBotaoLogin;

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputLogin = By.Id("Login");
            byInputSenha = By.Id("Password");
            byBotaoLogin = By.Id("btnLogin");
        }

        public LoginPO Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Autenticacao/Login");
            return this;
        }

        public LoginPO InformarEmail(string email)
        {
            driver.FindElement(byInputLogin).SendKeys(email);
            return this;
        }

        public LoginPO InformarSenha(string senha)
        {
            driver.FindElement(byInputSenha).SendKeys(senha);
            return this;
        }

        public LoginPO SubmeteFormulario()
        {
            driver.FindElement(byBotaoLogin).Submit();
            return this;
        }

        public LoginPO PreencheFormulario(string login, string senha)
        {
            driver.FindElement(byInputLogin).SendKeys(login);
            driver.FindElement(byInputSenha).SendKeys(senha);
            return this;
        }

        public void EfetuarLoginComCredenciais(string login, string senha)
        {
            Visitar()
                .PreencheFormulario(login, senha)
                .SubmeteFormulario();
        }
    }
}
