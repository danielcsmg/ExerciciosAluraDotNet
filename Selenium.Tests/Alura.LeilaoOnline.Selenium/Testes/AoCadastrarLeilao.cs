using System;
using System.Threading;
using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoCadastrarLeilao
    {
        readonly private IWebDriver driver;

        public AoCadastrarLeilao(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoLoginAdminEInfosValidasDeveCadastrarLeilao()
        {
            var loginPO = new LoginPO(driver);
            loginPO.Visitar();
            loginPO.PreencheFormulario("fulano@example.org", "123");
            loginPO.SubmeteFormulario();

            var leilaoPO = new NovoLeilaoPO(driver);
            leilaoPO.Visitar();
            leilaoPO.PreencherFormulario(
                "Titulo01",
                @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, 
sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, 
quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in 
reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat 
non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                2000.90,
                "C:\\Users\\Daniel.Caitano\\Pictures\\shellreverse.png",
                DateTime.Now.AddDays(20),
                DateTime.Now.AddDays(40)
                );
            Thread.Sleep(5000);

            loginPO.SubmeteFormulario();
        }
    }
}
