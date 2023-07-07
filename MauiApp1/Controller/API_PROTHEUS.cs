using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using MauiApp1.Models;


namespace MauiApp1.Controller
{
    public class API_PROTHEUS : IAPI_PROTHEUS
    {
        public API_PROTHEUS() { }

        public static HttpClient CONFIG_HTTP_PROT()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            HttpClient CLIENTE = new HttpClient(clientHandler);


            var authData = string.Format("{0}:{1}", "admin", "123456");
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            CLIENTE.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

            /*
             string JsonObjeto = JsonConvert.SerializeObject(CLIENTE);
             var content = new StringContent(JsonObjeto, Encoding.UTF8, "application/json");
             */
            return CLIENTE;

        }


        public List<SB1> GETPRODUTOS()
        {

            HttpClient httpClient = CONFIG_HTTP_PROT();
            string URLBASE = "http://192.168.0.111:8096/REST/AULA_1_1/PRD/ALL";

            var RESPONSE = httpClient.GetStringAsync(URLBASE);

            RESPONSE.Wait();

            if (RESPONSE.IsCompleted)
            {

                var RESULT = JsonConvert.DeserializeObject<List<SB1>>(RESPONSE.Result.ToString());
                return RESULT;
            }
            else
            {
                return null;
            }

        }


    }
}
