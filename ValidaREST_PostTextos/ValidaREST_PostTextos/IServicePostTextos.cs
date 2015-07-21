using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ValidaREST_PostTextos
{
    [ServiceContract]
    public interface IServicePostTextos
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "ValidaEstadisticasPostTexto/{texto}", ResponseFormat = WebMessageFormat.Json)]
        List<int> ValidaEstadisticasPostTexto(string texto);
    }
}
