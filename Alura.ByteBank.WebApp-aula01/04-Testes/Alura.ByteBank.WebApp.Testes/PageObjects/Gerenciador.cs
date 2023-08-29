using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Alura.ByteBank.WebApp.Testes.PageObjects
{
    public class Gerenciador : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public Gerenciador()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
