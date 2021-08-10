using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using System.IO;
using System.Configuration;

namespace DAL.CRUD.Stock
{
    public class Legajos
    {
        //#region Singleton
        //private static ISession session;
        //public static Legajos instancia = new Legajos();

        //private Legajos()
        //{
        //    session = DAL.Sesion.GenerarSesion.Instancia.Session;
        //}
        //#endregion    

        public Legajos()
        {

        }

        public BE.Stock.Legajos ObtenerListaImagenes(string pPatente, string pCodigoOblea)
        {
            var appconfig = ConfigurationManager.AppSettings;

            var legajo = new BE.Stock.Legajos
            {
                Patente = pPatente
            };

            string path = appconfig["PathLegajos"] + "\\" + pPatente + "\\";
            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] Files = d.GetFiles("P_" + pCodigoOblea + "*.jpg"); 

            foreach (FileInfo file in Files)
            {
                var legajoImagen = new BE.Stock.LegajoImagen();
                legajoImagen.NombreArchivo = file.Name;

                legajo.LegajoImagenes.Add(legajoImagen);
            }

            return legajo;
        }

        public BE.Stock.ImagenPieza ObtenerImagen(string pPatente, string pImagen)
        {
            var appconfig = ConfigurationManager.AppSettings;

            var imagen = new BE.Stock.ImagenPieza();

            string path = appconfig["PathLegajos"] + "\\" + pPatente + "\\";
            DirectoryInfo d = new DirectoryInfo(path);

            FileInfo[] Files = d.GetFiles(pImagen);

            foreach (FileInfo file in Files)
            {
                byte[] archivo = ReadAllBytes(file);
                //var legajoImagen = new BE.Stock.LegajoImagen();
                //legajoImagen.NombreArchivo = file.Name;
                ////legajoImagen.Imagen = archivo;

                //legajo.LegajoImagenes.Add(legajoImagen);
                imagen.Imagen = archivo;
            }

            return imagen;
        }

        private static Byte[] ReadAllBytes(FileInfo pArchivo)
        {
            return File.ReadAllBytes(pArchivo.FullName);
        }
    }
}
