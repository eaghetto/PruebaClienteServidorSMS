using System;

namespace PostTextos.Service.EstadisticasText
{
    public class EstadisticaNum_Caracteres : IEstadisticaPost
    {
        public int Validate(string texto)
        {
            try
            {
                int CuentaCaracteres = 0;

                CuentaCaracteres = texto.Length;

                return CuentaCaracteres;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
