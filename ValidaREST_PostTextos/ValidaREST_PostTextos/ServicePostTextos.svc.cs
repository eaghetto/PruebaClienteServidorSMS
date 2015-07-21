using PostTextos.Service;
using System.Collections.Generic;

namespace ValidaREST_PostTextos
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicePostTextos : IServicePostTextos
    {
        public List<int> ValidaEstadisticasPostTexto(string texto)
        {
            EstadisticasPostTexto est = new EstadisticasPostTexto();
            return est.Validate(texto);
        }
    }
}
