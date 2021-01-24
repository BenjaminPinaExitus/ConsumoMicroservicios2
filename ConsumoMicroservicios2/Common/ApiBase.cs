using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumoMicroservicios2.Common
{
    public class ApiBase
    {
        public RestSharp.RestClient Cliente;
        public RestSharp.RestRequest Request;

        public void Iniciar(string Url, RestSharp.Method Metodo)
        {
            Cliente = new RestSharp.RestClient(Url);
            Cliente.Timeout = -1;
            Request = new RestSharp.RestRequest(Metodo);
            Request.AddHeader("Content-Type", "application/json");
        }
    }
}