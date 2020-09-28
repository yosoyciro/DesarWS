using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using DAL.Mapeos;
using System.Configuration;
using BE.Tablas;

namespace DAL.Sesion
{
    public class GenerarSesion
    {

        #region ATRIBUTOS
        private ISessionFactory _sessionFactory;
        private ISession _session;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad sesión de NHibernate
        /// </summary>
        public ISession Session
        {
            get
            {
                if (null == this._session || !this._session.IsOpen)
                    this._session = this.OpenSession();

                return _session;

            }
            set { this._session = value; }
        }
        #endregion

        #region CONSTRUCTOR SINGLETON
        //public static GenerarSesion instance { get; private set; }
        private static volatile GenerarSesion instance;
        private static object syncRoot = new Object();
        GenerarSesion()
        {
        }

        public static GenerarSesion Instancia
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new GenerarSesion();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region METODOS CONFIGURACIÓN
        /// <summary>
        /// Método que abre la sesión
        /// </summary>
        /// <returns>La sesión activa</returns>
        private ISession OpenSession()
        {
            //Open and return the nhibernate session
            return this.SessionFactory().OpenSession();
        }

        /// <summary>
        /// Método que nos sirve para testear si tenemos conexión con la base de datos
        /// </summary>
        /// <returns>True si hay conexión y false en caso contrario</returns>
        public bool TestConnection()
        {
            ISessionFactory _iSession = this.SessionFactory();

            if (null == _iSession)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Método que crea la session factory
        /// </summary>
        public ISessionFactory SessionFactory()
        {
            try
            {
                //Siempre que no la hayamos creado antes
                if (_sessionFactory == null)
                {
                    var cfg = new NHibernate.Cfg.Configuration();
                    var appconfig = ConfigurationManager.AppSettings;
                    switch (appconfig["Ambiente"])
                    {
                        case "Test":
                            cfg.Configure("D:/Desarrollo/C#/Desarm/WebApi/bin/Conexion/test.cfg.xml");
                            break;

                        case "TestDatacenterRemoto":
                            cfg.Configure("D:/Desarrollo/C#/Desarm/WebApi/bin/Conexion/testdatacenter.cfg.xml");
                            break;

                        case "Produccion":
                            cfg.Configure("/inetpub/wwwroot/Desarm/bin/Conexion/produccion.cfg.xml");
                            break;

                        case "TestDatacenter":
                            cfg.Configure("/inetpub/wwwroot/DesarmTest/bin/Conexion/testdatacenter.cfg.xml");
                            break;
                    }

                    var mapper = new ModelMapper();

                    //Especifico uno por unos los mapeos de las entidades
                    mapper.AddMapping<MapMarcas>();
                    mapper.AddMapping<MapModelos>();
                    mapper.AddMapping<MapVehiculosTipo>();
                    mapper.AddMapping<MapArticulos>();
                    mapper.AddMapping<MapTiposCombustible>();
                    mapper.AddMapping<MapLocalidades>();
                    mapper.AddMapping<MapProvincias>();
                    mapper.AddMapping<MapPedidosWeb>();
                    mapper.AddMapping<MapPedidosWeDetalle>();
                    mapper.AddMapping<MapPedidosWebFormasPago>();
                    mapper.AddMapping<MapPersonasWeb>();
                    mapper.AddMapping<MapPersonas>();
                    mapper.AddMapping<MapEmpleados>();
                    mapper.AddMapping<MapCanalesVenta>();
                    mapper.AddMapping<MapFormasPago>();
                    mapper.AddMapping<MapCanalesVentaForPag>();
                    mapper.AddMapping<MapPedidosWebArchivos>();
                    mapper.AddMapping<MapArticulosAsociados>();
                    mapper.AddMapping<MapPedidosWebTarjetasCupones>();
                    mapper.AddMapping<MapTarjetasEmisor>();
                    mapper.AddMapping<MapTarjetasEntidades>();
                    mapper.AddMapping<MapTarjetasPlanes>();
                    mapper.AddMapping<MapTarjetasPlanesEmisor>();
                    mapper.AddMapping<MapPersonasConsulta>();

                    var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

                    cfg.AddMapping(mapping);

                    _sessionFactory = cfg.BuildSessionFactory();
                }
                return _sessionFactory;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

    }
}

