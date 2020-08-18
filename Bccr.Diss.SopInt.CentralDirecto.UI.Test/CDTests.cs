using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Xunit;
namespace Bccr.Diss.SopInt.CD.UI.Tests
{
    public class CDTests
    {
        private readonly IWebDriver driver = Factory.driver;
        [Fact]
        private void Login()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));

            //Cargar Central Directo Pruebas
            driver.Navigate().GoToUrl($"{Factory.serverName}{Factory.homeUrl}");

            AgregueUnaPausaDecorativa();

            //Presionar el botón ingresar con firma digital
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(Factory.homeBotonAutenticar))).Click();

            AgregueUnaPausaDecorativa();

            //Ingresar la cédula del usuario de manera controlada
            var elCampoDeCedula = wait.Until(ExpectedConditions.ElementExists(By.XPath(Factory.userIDInput)));
            IngreseElDatoDeManeraControlada(elCampoDeCedula, Factory.userIDValue);

            AgregueUnaPausaDecorativa();

            //Ingresar a la página principal CD multinegocio
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(Factory.homeBotonFirmar))).Click();

            AgregueUnaPausaDecorativa();

            //Seleccionar las opciones de Persona Jurídica
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("input#business + label"))).Click();

            //Hacer visible el negocio RTBF
            string elPathDelNegocioRTBF = Factory.pathNegocioRTBF;
            var elNegocioRTBF = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elPathDelNegocioRTBF)));
            new Actions(driver).MoveToElement(elNegocioRTBF).Perform();

            AgregueUnaPausaDecorativa();

            //Seleccionar suscribir una entidad
            string elPathDelRadioSuscribir = Factory.pathSuscribir;
            var elRadioButtonSuscribir = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elPathDelRadioSuscribir)));
            elRadioButtonSuscribir.Click();

            AgregueUnaPausaDecorativa();

            //Ingresar la cédula de la entidad
            string laCedulaJuridica = Factory.pathCedulaJuridicaRTBF;
            var elCampoCedulaJuridica = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(laCedulaJuridica)));
            //Focus para evitar conflictos con la máscara
            new Actions(driver).MoveToElement(elCampoCedulaJuridica).Click().Perform(); 
            elCampoCedulaJuridica.SendKeys(Factory.fideicomsisoADeclarar);

            AgregueUnaPausaDecorativa();

            //Presionar el botón ingrese
            string elPathDelBotonIngrese = Factory.pathIngresoJuridicoRTBF;
            var elBotonIngrese = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elPathDelBotonIngrese)));
            elBotonIngrese.Click();

            AgregueUnaPausaDecorativa();

            //Seleccionar menu Registro de Accionistas
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"si_2\"]"))).Click();

            Factory.Pause(10);
            driver.Dispose();
        }

        private static void AgregueUnaPausaDecorativa()
        {
            Factory.Pause(3); //Pausa decorativa para apreciar las acciones, se puede eliminar.            
        }

        private void IngreseElDatoDeManeraControlada(IWebElement elInput, string elDatoAIngresar)
        {
            foreach (char digito in elDatoAIngresar)
            {
                elInput.SendKeys(digito.ToString());
                Factory.Pause(0.3);
            }
        }
    }
}
