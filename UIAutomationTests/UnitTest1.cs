using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;

namespace UIAutomationTests
{
    public class SeleniumTests
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void CreateCountry_Test()
        {
            // Navegar a la app
            _driver.Navigate().GoToUrl("http://localhost:8080/");
            Thread.Sleep(1000);

            // Assert 1: título de la página
            Assert.That(_driver.Title, Is.EqualTo("frontend-lab"));

            // Assert 2: tabla existe
            IWebElement tabla = _driver.FindElement(By.TagName("table"));
            Assert.That(tabla, Is.Not.Null);

            // Click en Agregar país
            IWebElement btnAgregar = _driver.FindElement(
                By.XPath("//button[contains(text(),'Agregar')]"));
            btnAgregar.Click();
            Thread.Sleep(1000);

            // Assert 3: formulario cargó
            IWebElement form = _driver.FindElement(By.TagName("form"));
            Assert.That(form, Is.Not.Null);

            // Llenar formulario
            _driver.FindElement(By.Id("name")).SendKeys("PaísTest");

            var select = new SelectElement(
                _driver.FindElement(By.Id("continente")));
            select.SelectByText("América");

            _driver.FindElement(By.Id("idioma")).SendKeys("Español");

            // Guardar
            _driver.FindElement(
                By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(1000);

            // Assert 4 y 5: volvió a la lista y país nuevo aparece en la tabla
            Assert.Multiple(() =>
            {
                Assert.That(_driver.Url, Is.EqualTo("http://localhost:8080/"));
                Assert.That(_driver.PageSource, Does.Contain("PaísTest"));
            });
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}