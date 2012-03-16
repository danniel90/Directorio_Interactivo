using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;


namespace DirectorioInteractivoLogic
{
    public class Directorio
    {
        private directorioEntities entidad;

        public Directorio()
        {
            try
            {
                entidad = new directorioEntities();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / Directorio()");
            }
        }

        #region usuarios
        
        public void CrearUsuario(string nombre_usuario, string primer_nombre, string segundo_nombre,
                                 string primer_apellido, string segundo_apellido, string email, string password)
        {
            try
            {
                USUARIO usuarioNuevo = new USUARIO();
                usuarioNuevo.NOMBRE_USUARIO = nombre_usuario;
                usuarioNuevo.PRIMER_NOMBRE = primer_nombre;
                usuarioNuevo.SEGUNDO_NOMBRE = segundo_nombre;
                usuarioNuevo.PRIMER_APELLIDO = primer_apellido;
                usuarioNuevo.SEGUNDO_APELLIDO = segundo_apellido;
                usuarioNuevo.EMAIL = email;
                usuarioNuevo.PASSWORD = password;

                entidad.AddToUSUARIOS(usuarioNuevo);
                entidad.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / CrearUsuario()");
            }
        }

        #endregion

        #region edificios

        public void CrearEdificio(string nombre, string descripcion)
        {
            try
            {
                EDIFICIO edificioNuevo = new EDIFICIO();
                edificioNuevo.NOMBRE = nombre;
                edificioNuevo.DESCRIPCION = descripcion;

                entidad.AddToEDIFICIOS(edificioNuevo);
                entidad.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / CrearEdificio()");
            }
        }
        
        #endregion

        #region niveles

        public void CrearNivel(int numero, string descripcion)
        {
            try
            {
                NIVEL nivelNuevo = new NIVEL();
                nivelNuevo.NUMERO = numero;
                nivelNuevo.DESCRIPCION = descripcion;

                entidad.AddToNIVELES(nivelNuevo);
                entidad.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / CrearNivel()");
            }
        }

        #endregion

        #region locales

        public void CrearLocal(string nombre, string descripcion, string tipo)
        {
            try
            {
                var tipoQuery = from t in entidad.TIPO_LOCAL
                                where t.TIPO == tipo
                                select t;

                LOCAL localNuevo = new LOCAL();
                localNuevo.NOMBRE = nombre;
                localNuevo.DESCRIPCION = descripcion;
                localNuevo.LOCAL_TIPOS = tipoQuery.First();

                entidad.AddToLOCALES(localNuevo);
                entidad.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / CrearLocal()");
            }
        }

        #endregion

        #region tipo local

        public void CrearTipoLocal(string tipo)
        {
            try
            {
                TIPO_LOCAL tipoNuevo = new TIPO_LOCAL();
                tipoNuevo.TIPO = tipo;

                entidad.AddToTIPO_LOCAL(tipoNuevo);
                entidad.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString() + " -- Directorio.cs / CrearTipoLocal()");
            }
        }

        #endregion
    }
}
