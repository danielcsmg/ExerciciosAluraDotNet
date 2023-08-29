using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class NovoLeilaoPO
    {
        readonly private IWebDriver driver;
        private readonly By byInputTitulo;
        private readonly By byInputDescricao;
        private readonly By byInputCategoria;
        private readonly By byInputValorInicial;
        private readonly By byInputImagem;
        private readonly By byInputInicioPregao;
        private readonly By byInputTerminoPregao;
        public IEnumerable<string> Categorias
        {
            get
            {
                var elementoCategoria = new SelectElement(driver.FindElement(byInputCategoria));
                return elementoCategoria.Options
                    .Where(o => o.Enabled)
                    .Select(o => o.Text);
            }
        }

        public NovoLeilaoPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputTitulo = By.Id("Titulo");
            byInputDescricao = By.Id("Descricao");
            byInputCategoria = By.Id("Categoria");
            byInputValorInicial = By.Id("ValorInicial");
            byInputImagem = By.Id("ArquivoImagem");
            byInputInicioPregao = By.Id("InicioPregao");
            byInputTerminoPregao = By.Id("TerminoPregao");
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Leiloes/Novo");
        }

        public void PreencherFormulario(
            string titulo,
            string descricao,
            double valorInicial,
            string imagem,
            DateTime inicioPregao,
            DateTime terminoPregao
            )
        {

            driver.FindElement(byInputTitulo).SendKeys(titulo);
            driver.FindElement(byInputDescricao).SendKeys(descricao);
            driver.FindElement(byInputValorInicial).SendKeys(valorInicial.ToString());
            driver.FindElement(byInputImagem).SendKeys(imagem);
            driver.FindElement(byInputInicioPregao).SendKeys(inicioPregao.ToString("dd/MM/yyyy"));
            driver.FindElement(byInputTerminoPregao).SendKeys(terminoPregao.ToString("dd/MM/yyyy"));
        }
    }
}
