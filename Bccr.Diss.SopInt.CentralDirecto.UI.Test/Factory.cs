using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Bccr.Diss.SopInt.CD.UI.Tests
{
    public static class Factory
    {
        #region "No editar, a menos que sea realmente necesario"
        public static IWebDriver driver = new ChromeDriver();
        public const string serverName = "https://centraldirectopruebas.dmz-p.local";

        public const string userIDInput = "/html/body/div[2]/div/div[1]/div/div[2]/input";
        public const string userIDValue = "02-0611-0565";
        public const string fideicomsisoADeclarar = "3-110-716998";
        public const string pathNegocioRTBF = "//*[@id=\"seccionNegocios\"]/div/div[2]/div";
        public const string pathSuscribir = "//*[@id=\"seccionNegocios\"]/div/div[2]/div/div[3]/form/div[1]/div[2]/label";
        public const string pathCedulaJuridicaRTBF = "/html/body/div/div[5]/div[2]/div[1]/div[2]/div/div[1]/div[2]/div[2]/div/div[2]/div/div[3]/form/div[1]/div/div/input";
        public const string pathIngresoJuridicoRTBF = "//*[@id=\"seccionNegocios\"]/div/div[2]/div/div[3]/form/div[2]/input";

        public const string homeUrl = "/Sitio/CentralDirecto/";
        public const string homeUrlTitulo = "Página Principal";
        public const string homeBotonAutenticar = "//*[@id=\"BotonDeAutenticar\"]";
        public const string homeUserValidated = "Bienvenido(a) AMELIA ZUÑIGA ZUÑIGA";
        public const string homeBotonFirmar = "/html/body/div[2]/div/div[1]/div/div[6]/div[1]";
        public const string homeRadioButon = "//*[@id=\"seccionPersonal\"]/div/div[3]/div/div[3]/form/div[1]/div/label/input";
        public const string homeBotonIngrese = "//*[@id=\"seccionPersonal\"]/div/div[3]/div/div[3]/form/div[2]/input";
                                               
        public const string homeFormularioNegocio = "//*[@id=\"seccionPersonal\"]/div/div[3]/div/div[3]/form";
        
        public const string BotonNuevaSesion = "div_boton_ingresar";
        public const string BotonCerrar = "//*[@id=\"AccionCerrar\"]/div";

        public const string cerrarSesion = "/Sitio/Publico/SesionDesconectada.aspx";
        public const string cerrarSesionTitulo = "Desconexión Completa";
        public static void Pause(double seconds = 7)
        {
            Thread.Sleep(TimeSpan.FromSeconds(seconds));
        }
        #endregion

        public const string ListaDeUsuarios = "/Sitio/AESV2/Usuarios";
        public const string ListaDeUsuariosTitulo = "Lista de Usuarios";
               
        public const string DatosDeMiEntidad = "/Sitio/AESV2/Entidades";
        public const string DatosDeMiEntidadTitulo = "Datos de mi entidad";
               
        public const string Expedientes = "/Sitio/AESV2/Documentos";
        public const string ExpedientesTitulo = "Expediente de documentos de mi entidad";
               
        public const string ConozcaAsuCliente = "/Sitio/AesSinpeV2/ConozcaASuCliente";
        public const string ConozcaAsuClienteTitulo = "Conozca a su cliente";
               
        public const string CuentasDeCentralDirecto       = "/Sitio/CTAV2/CuentasClienteInversion";
        public const string CuentasDeCentralDirectoTitulo = "Cuentas de Central Directo";
               
        public const string CuentasBancarias = "/Sitio/CTAV2/CuentasCliente";
        public const string CuentasBancariasTitulo = "Cuentas bancarias";

        public const string Beneficiarios = "/Sitio/CTAV2/Beneficiarios";
        public const string BeneficiariosTitulo = "Beneficiarios";

        public const string Transferencias = "/Sitio/TFOv2/Transferencias";
        public const string TransferenciasTitulo = "Transferencias";

        public const string IngresoAMonex = "/Sitio/Mex/IngresoMonex.aspx";
        public const string IngresoAMonexTitulo = "Ingreso a MONEX";

        public const string OfertasPublicadas = "/Sitio/Mex/OpcionOfertasPublicadas.aspx";
        public const string OfertasPublicadasTitulo = "Ofertas Publicadas";

        public const string Calces = "/Sitio/Mex/OpcionCalces.aspx";
        public const string CalcesTitulo = "Calces";

        public const string OrdenesDeInversion = "/Sitio/NEG/INV/OrdenInversion";
        public const string OrdenesDeInversionTitulo = "Órdenes de Inversión";

        public const string Inversiones = "/Sitio/NEG/INV/Inversion";
        public const string InversionesTitulo = "Inversiones";
    }

}
