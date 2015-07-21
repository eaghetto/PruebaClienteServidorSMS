using System;
using System.Linq;

namespace PostTextos.Service.EstadisticasText
{
    public class EstadisticaNum_Oraciones : IEstadisticaPost
    {
        public int Validate(string texto)
        {
            try
            {
                int noPalabra = 0;
                int noOracion = 0;

                //separo cada palabra
                string[] palabras = texto.Split(' ');

                foreach (var item in palabras)
                {
                    if (!item.Contains('.'))
                        noPalabra++;
                    else
                    {
                        if (noPalabra >= 15 && !item.Contains(','))
                            noOracion++;

                        noPalabra = 0;
                    }
                }

                return noOracion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
