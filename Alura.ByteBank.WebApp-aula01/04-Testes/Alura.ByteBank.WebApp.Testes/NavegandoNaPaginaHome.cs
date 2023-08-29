using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Alura.ByteBank.WebApp.Testes.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using Xunit.Abstractions;

namespace Alura.ByteBank.WebApp.Testes
{
    public class NavegandoNaPaginaHome : IClassFixture<Gerenciador>
    {
        readonly ITestOutputHelper _output;
        readonly LoginPO _login;

        public NavegandoNaPaginaHome(ITestOutputHelper output, Gerenciador gerenciador)
        {
            _output = output;
            var driver = gerenciador.Driver;
            _login = new LoginPO(driver);
        }

        [Fact]
        public void CarregandoPaginaHomeEVerificandoTituloDaPagina()
        {
            //Arrange

            //Act
            _login.Navegar("https://localhost:44309");

            //Assert
            Assert.Contains("WebApp", _login.GetPageSource());
            Assert.Contains("Login", _login.GetPageSource());
            Assert.Contains("Home", _login.GetPageSource());
            _login.Close();
        }

        [Fact]
        public void LogandoNoSistema()
        {
            //Arrange
            _login.Navegar("https://localhost:44309");
            _login.IrParaAPagina("Login");

            //Act
            _login.PreencherCampos("andre@email.com", "senha01");
            _login.BtnClickLogin();

            //Assert
            _login.ClicarNoElemento("agencia");
            _login.ClicarNoElemento("home");
           
            _login.Close();
        }

        [Fact]
        public void TentaLogarNoSistemaSemSenhaEEmail()
        {
            //Arrange

            //Act
            _login.Navegar("https://localhost:44309");
            _login.IrParaAPagina("Login");
            _login.PreencherCampos("", "");

            //Assert
            Assert.Contains("The Email field is required", _login.GetPageSource());
            Assert.Contains("The Senha field is required", _login.GetPageSource());

            _login.Close();
        }

        [Fact]
        public void TentaAcessarPaginaSemLogar()
        {
            //Arrange

            //Act
            _login.Navegar("https://localhost:44309/Agencia/Index");

            //Assert
            Assert.Contains("https://localhost:44309/Agencia/Index", _login.GetUrl());
            Assert.Contains("401", _login.GetPageSource());

            _login.Close();
        }

        [Fact]
        public void TestandoOTagName()
        {
            //Arrange
            _login.Navegar("https://localhost:44309");
            _login.IrParaAPagina("Login");

            //Act
            _login.PreencherCampos("andre@email.com", "senha01");
            _login.BtnClickLogin();

            _login.ClicarNoElemento("contacorrente");

            IReadOnlyCollection<IWebElement> elements = _login.GetElementsByTagName("a");

            foreach (IWebElement element in elements)
            {
                _output.WriteLine(element.Text);
            }

            //Assert

            _login.Close();
        }
    }
}