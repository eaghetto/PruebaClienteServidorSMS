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
                Regex valExpresion = new Regex("n$ | N$");
                int noPalabra = 0;

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
