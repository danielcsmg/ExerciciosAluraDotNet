using System;
using System.Collections.Generic;
using System.Text;
using Alura.LeilaoOnline.Selenium.Helpers;
using System.Threading;
using OpenQA.Selenium;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class FiltroLeiloesPO
    {
        private IWebDriver driver;
        private By bySelectCategorias;
        private By byInputTermo;
        private By byInputAndamento;
        private By byBtnPesquisar;

        public FiltroLeiloesPO(IWebDriver driver)
        {
            this.driver = driver;
            bySelectCategorias = By.ClassName("select-wrapper");
            byInputTermo = By.Id("termo");
            byInputAndamento = By.ClassName("lever");
            byBtnPesquisar = By.CssSelector("form>button.btn");
        }

        public void PesquisarLeiloes(
            List<string> categorias,
            string termo,
            bool emAndamento)
        {
            //Primeira forma
            //var selectWrapper = driver.FindElement(bySelectCategorias);
            //selectWrapper.Click();

            //Forma mais indicada com uma classe separada
            var select = new SelectMaterialize(driver, bySelectCategorias);

            //Primeira forma
            //var opcoes = selectWrapper
            //    .FindElements(By.CssSelector("li>span"))
            //    .ToList();
            //opcoes.ForEach(o => { o.Click(); });

            //Forma mais indicada com uma classe separada
            select.DeselectAll();


            categorias.ForEach(categ =>
            {
                //Primeira forma
                //opcoes
                //    .Where(o => o.Text.Contains(categ))
                //    .ToList()
                //    .ForEach(o => { o.Click(); });

                //Forma mais indicada com uma classe separada
                select.SelectByText(categ);

            });

            driver.FindElement(byInputTermo).SendKeys(termo);
            if (emAndamento)
            {
                driver.FindElement(byInputAndamento).Click();
            }
            Thread.Sleep(4000);

            driver.FindElement(byBtnPesquisar).Click();

            //Este trecho foi embutido na função .SelectByText()
            //selectWrapper
            //    .FindElement(By.TagName("li"))
            //    .SendKeys(Keys.Tab);

        }
    }
}
