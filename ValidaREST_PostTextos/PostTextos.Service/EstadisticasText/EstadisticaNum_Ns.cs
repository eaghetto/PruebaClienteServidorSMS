using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PostTextos.Service.EstadisticasText
{
    public class EstadisticaNum_Ns : IEstadisticaPost
    {
        public int Validate(string texto)
        {
            try
            {
                int noPalabra = 0;
               
                texto = texto.Replace(".", "").Replace(",", "");
                Regex valExpresion = new Regex(@"[n|N]$");
            
                //separo cada palabra
                string[] palabras = texto.Split(' ');

                var nFinal = from c in palabras
                                where valExpresion.Matches(c).Count > 0
                                select c;

                noPalabra = nFinal.Count();

                return noPalabra;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
