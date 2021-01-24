using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumoMicroservicios2.Common
{
    public class Api : ApiBase
    {
        public List<Models.Catalogo> GetCatalogosList()
        {
            var resultadoList = new List<Models.Catalogo>();

            try
            {
                this.Iniciar(string.Format("{0}/GetCatalogo", Properties.Settings.Default.MSCatalogos), RestSharp.Method.GET);
                Request.AddParameter("application/json", "", RestSharp.ParameterType.RequestBody);

                RestSharp.IRestResponse respuesta = Cliente.Execute(Request);

                if (respuesta.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    resultadoList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Catalogo>>(respuesta.Content);
                }
            }
            catch (Exception ex)
            {

            }

            return resultadoList;
        }

        public bool SetCatalogo(Models.Catalogo Ent)
        {
            var resultado = false;

            try
            {
                this.Iniciar(string.Format("{0}/SetCatalogo", Properties.Settings.Default.MSCatalogos), RestSharp.Method.POST);
                Request.AddJsonBody(Ent);
                RestSharp.IRestResponse respuesta = Cliente.Execute(Request);

                resultado = (respuesta.StatusCode == System.Net.HttpStatusCode.OK);
                
            }
            catch (Exception)
            {

            }

            return resultado;
        }
    }
}