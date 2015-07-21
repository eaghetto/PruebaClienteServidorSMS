using PostTextos.Service.EstadisticasText;
using System.Collections.Generic;
using System.Linq;

namespace PostTextos.Service
{
    public class EstadisticasPostTexto
    {
        private readonly List<IEstadisticaPost> validaTexto;
        
        public EstadisticasPostTexto()
        {
            validaTexto = new List<IEstadisticaPost>()
            {
               new EstadisticaNum_Ns(),
               new EstadisticaNum_Oraciones(),
               new EstadisticaNum_Parrafos(),
               new EstadisticaNum_Caracteres()
            };
        }

        public List<int> Validate(string texto)
        {
            var estadistica = new List<int>();
            foreach (var respuestaEst in validaTexto.Select(item => item.Validate(texto)))
            {
                estadistica.Add(respuestaEst);
            }

            return estadistica;
        }
    }
}
