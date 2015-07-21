using System;
using System.Linq;

namespace PostTextos.Service.EstadisticasText
{
    public class EstadisticaNum_Parrafos : IEstadisticaPost
    {
        public int Validate(string texto)
        {
            try
            {
                //separo cada parrafo
                string[] parrafo = texto.Split(',');
                
                return parrafo.Count() - 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
