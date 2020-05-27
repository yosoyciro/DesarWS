using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BLL
{
    public class Funciones
    {
        #region Singleton
        public static Funciones instancia = new Funciones();

        private Funciones()
        {
        }
        #endregion        
        public string CleanInput(string strIn)
        {
            if (strIn == "")
            {
                return String.Empty;
            }

            else
            {
                // Replace invalid characters with empty strings.
                try
                {
                    return Regex.Replace(strIn, @"[^\w\.@-]", " ", RegexOptions.None, TimeSpan.FromSeconds(1.5));
                }
                catch (RegexMatchTimeoutException)
                {
                    return String.Empty;
                }
            }
        }

        public int ConvertirFecha(DateTime pFechaNormal)
        {
            DateTime FechaBase = new DateTime(1801, 01, 01);
            int FechaClarion = ((TimeSpan)(pFechaNormal - FechaBase.AddDays(-4))).Days;
            return FechaClarion;
        }
    }
}
