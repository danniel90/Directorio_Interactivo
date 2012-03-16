using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using DirectorioInteractivoLogic;

namespace DirectorioInteractivoWS
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DirectorioService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void CrearUsuario(string nombre_usuario, string primer_nombre, string segundo_nombre,
                                 string primer_apellido, string segundo_apellido, string email, string password)
        {
            try
            {
                Directorio dir = new Directorio();
                dir.CrearUsuario(nombre_usuario, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, email, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- DirectorioService.asmx.cs / CrearUsuario()");
            }
        }

        [WebMethod]
        public void CrearEdificio(string nombre, string descripcion)
        {
            try
            {
                Directorio dir = new Directorio();
                dir.CrearEdificio(nombre, descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- DirectorioService.asmx.cs / CrearEdificio()");
            }
        }

        [WebMethod]
        public void CrearNivel(int numero, string descripcion)
        {
            try
            {
                Directorio dir = new Directorio();
                dir.CrearNivel(numero, descripcion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- DirectorioService.asmx.cs / CrearNivel()");
            }
        }

        [WebMethod]
        public void CrearLocal(string nombre, string descripcion, string tipo)
        {
            try
            {
                Directorio dir = new Directorio();
                dir.CrearLocal(nombre, descripcion, tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- DirectorioService.asmx.cs / CrearLocal()");
            }
        }

        [WebMethod]
        public void CrearTipoLocal(string tipo)
        {
            try
            {
                Directorio dir = new Directorio();
                dir.CrearTipoLocal(tipo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- DirectorioService.asmx.cs / CrearTipoLocal()");
            }
        }
    }
}