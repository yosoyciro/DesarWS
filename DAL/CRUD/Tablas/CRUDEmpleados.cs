using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE.Tablas;
using NHibernate;

namespace DAL.CRUD.Tablas
{
    public class CRUDEmpleados
    {
        #region Singleton
        private static ISession session;
        public static CRUDEmpleados instancia = new CRUDEmpleados();

        private CRUDEmpleados()
        {
            session = DAL.Sesion.GenerarSesion.Instancia.Session;
        }
        #endregion        

        #region Consultar
        /*public IList<Empleados> Login(Empleados pEmpleados)
        {
            return session.Query<Empleados>().Where(a => a.USUARIO == pEmpleados.USUARIO && a.PASSWORD == pEmpleados.PASSWORD).ToList();
        }*/
        public bool Login(Empleados pEmpleados)
        {
            Empleados empleado = session.Query<Empleados>().Where(a => a.USUARIO == pEmpleados.USUARIO && a.PASSWORD == pEmpleados.PASSWORD).SingleOrDefault();

            switch (empleado)
            {
                case null:
                    return false;
                default:
                    break;
            }
            //Comparo usuario
            string usuarioDB = empleado.USUARIO;
            string usuarioLogin = pEmpleados.USUARIO;
            bool resultadoUsuario = usuarioDB.Equals(usuarioLogin, StringComparison.Ordinal);

            //comparo pass
            string passDB = empleado.PASSWORD;
            string passLogin = pEmpleados.PASSWORD;
            bool resultadoPass = passDB.Equals(passLogin, StringComparison.Ordinal);

            if (resultadoUsuario == false || resultadoPass == false)
                return false;
            else
                return true;

        }
        #endregion
    }
}
