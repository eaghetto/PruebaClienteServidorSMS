using System;

namespace PostTextos.Service.EstadisticasText
{
    public class EstadisticaNum_Caracteres : IEstadisticaPost
    {
        public int Validate(string texto)
        {
            try
            {
                string transformaTexto = texto.Replace("N", "").Replace("n", "").Replace(" ", "").Replace(".", "").Replace(",", "");

                return transformaTexto.Length;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
