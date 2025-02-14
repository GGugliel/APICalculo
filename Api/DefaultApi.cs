using Microsoft.AspNetCore.Mvc;
using APICalculo.Client;
using APICalculo.Model;
using APICalculo.Interfaces;

namespace APICalculo.Api
{
    [ApiController]
    [Route("Api")]
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DefaultApi : BaseController
    {
        private readonly ApiClient apiclient;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DefaultApi(ApiClient? apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                apiclient = Configuration.DefaultApiClient;
            else
                apiclient = apiClient;
        }

        /// <summary>
        ///  Gerar access token
        /// </summary>
        /// <returns>Sucess</returns>
        [HttpPost("Auth")]
        [ProducesResponseType(typeof(ResponseAuth), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult?> Auth()
        {
            RequestAuth body = new RequestAuth()
            {
                GrantType = "client_credentials",
                Scope = "web",
                ClientSecret = "NQlQ7TrkD2+JChzMpp5xRBbbCnoHhmKwgG/2eKUKAwA=",
                ClientId = "ecommerce",
                Token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJicmFkZXNjbyIsImF1ZCI6ImRhdGFwb3dlciIsImlhdCI6MTYzMjI5OTkwMiwiZXhwIjoxNjMyMzI1MTAyLCJ0Y3IiOiJjcGYiLCJ1c3IiOiIwNTc2NjgwMzU0MCIsInB3ZCI6IkpvcmdlMTIzIn0.MmThi_GL9KaEk9nv4qB064mbWo2Y10q_nUYg6FCvlJE"
            };

            var formParams = new Dictionary<String, String>()
            {
                {"grant_type",body.GrantType},
                {"scope",body.Scope},
                {"client_secret",body.ClientSecret},
                {"client_id",body.ClientId},
                {"token",body.Token}
            };

            var path = apiclient.BasePath + "/V2/Auth";

            // authentication setting, if any
            String[] authSettings = new String[] { };

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var postBody = apiclient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            //var response = apiclient.CallApi<ResponseAuth>(path, HttpMethod.Post, queryParams, postBody, headerParams, formParams, authSettings);
            var response = await apiclient.CallApi<object, ResponseAuth>(null, path, HttpMethod.Post, queryParams, postBody, headerParams, formParams, authSettings);

            return ProcessResponse(response);
        }

        /// <summary>
        ///  Gerar access token
        /// </summary>
        /// <returns>Sucess</returns>
        [HttpPost("CreateJWT")]
        [ProducesResponseType(typeof(ResponseCreateJWT), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult?> BSADDatapowerCreateJWT([FromHeader] string AccessToken, [FromHeader] string QueryString)
        {
            var path = apiclient.BasePath + "/V2/BSAD-DatapowerCreateJWT";

            // authentication setting, if any
            String[] authSettings = new String[] { };

            var queryParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>()
            {
                {"Authorization", "Bearer " + AccessToken},
                {"client_id","ecommerce"},
                {"qryParams",QueryString},
                {"type","JWT"},
                {"cipher","true"},
                {"format","json"}
            };
            var postBody = ""; // http body (model) parameter

            // make the HTTP request
            //var response = apiclient.CallApi<ResponseAuth>(path, HttpMethod.Post, queryParams, postBody, headerParams, formParams, authSettings);
            var response = await apiclient.CallApi<Object, ResponseCreateJWT>(request: null, path: path, method: HttpMethod.Post, queryParams: queryParams, postBody: postBody, headerParams: headerParams, formParams: formParams, authSettings: authSettings);

            return ProcessResponse(response);

        }


        /// <summary>
        ///  método de efetivação, produto negociavel
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Sucess</returns>
        [HttpGet("ConsultaDadosCotacao")]
        [ProducesResponseType(typeof(ConsultaDadosCotacaoResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ConsultaDadosCotacaoGet([FromHeader] string Access_token, [FromHeader] string CriptoParameters)
        {
            var path = apiclient.BasePath + "/V2/prweb/PRRestService/APINegociaveis/v1/ConsultarDadosCotacao";

            var queryParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, String>();
            var postBody = new Dictionary<String, String>();  // http body (model) parameter
            var headerParams = new Dictionary<String, String>()
                {
                   {"Authorization", "Bearer " + Access_token},
                   {"token", CriptoParameters}
                };

            // make the HTTP request
            //RestResponse response = (RestResponse)apiclient.CallApi(path, HttpMethod.Get, queryParams, null, headerParams, formParams, fileParams);
            var response = await apiclient.CallApi<object, ConsultaDadosCotacaoResponse>(null, path, HttpMethod.Get, queryParams, null, headerParams, null);

            return ProcessResponse(response);
        }

        /*
            [HttpPost("consultaDadosParcelaBilhetesContratado")]
            /// <summary>
            ///  Gerar access token
            /// </summary>
            /// <returns>Sucess</returns>
            public async Task<ResponseConsultarDadosParcelaBilhetesContratado?> ModuloConsulta([FromHeader] string Access_token, RequestConsultarDadosParcelaBilhetesContratado request)
            {
                var path = apiclient.BasePath + "/V2/AFND-Webservices/moduloconsulta";

                //var Access_token = "eyJlbmMiOiJBMTI4Q0JDLUhTMjU2IiwiYWxnIjoiUlNBMV81IiwiY3R5IjoiSldUIn0.Uh9tLxu_nOZ0gz4rgL3VSDIQ4oLJSrfVcVTD1a73kA9TlyXNk6ZaXiIrwz0DuOfSP0EyRGaMYcDffbtx_sNz4mRAFC3IbHsPrnx88-OqDkN0X3BQ85h-tM4Y7sJ2EL6wayXiFbo6lz5y_EZdqqBz0muCtQ7t_TIh-QFonuyJYNs6kjTcdwBTdIGNaZcNaB8_ZpZRNSm7VZhYDs9s7K5HDTFcPxhD21fCzWq4yB2ckopP_9DS3d-_IABqmrtSGS_YCfBvwwA-Z1RB5YvWNxizOuUZqDJoBSf6nm4jMNiBW5Evw2bnHpGTnHjOBjQXFjNEKjCN9IDIGx2gIEgTraZOjw.S-uUUqpq1rdp-nZqSczasA.wCsiI9bgZLNsOFRKfabvmktN9VDNyCgH5vpfodK_BAlob5g_HWtCKO7z8GMnNf_ZFMNfP6GSMCV2LD0B-W-fr6ngA3ukfXsmTZ0FccbRIqMtGt0V82CKCMiM9waQwLSRwNT4mim_yoYfXlnkqsKlUtYJ5LuIIylU1g6MZWgll8bsm4HOa-8dI_LYdfySh-KdonfUgALRaCh9kaFC0VqiKx8MebUxim9e0cmnbxUMb7yRAXtx4hK9NEdCHr0y-JAJgrvoppkvwFVw38DL-kOZGpUx9MYjIfdq7127acOAB2Op195iNcb4BtSiWXZaI0mjW_QCHCaEuio2_zXtoyNt-mrT3viTjQTDgDLF7nosRF-jjEMk5hOhVrcWULFGH3C7U0LB-oKf0QVTSc11PJQrjEvCqKTpRFHb2G5N0gxYL4u9Cv79apTibPoaP3RP1tJ_EKtOqLxXy051qX49XgpYNWULcdSljM-SIDc5RxKzcPicoV8oTrq-s-1rdVbrMyBaW7wZl_b99cQSTkzKI8tF46Vlzd236UrsTLJo-xC2cnowO6y0kpdBzEiD6nIlrigiUS1mkwA4cunCRjt_rq5wn5B_U0TN16zb9v42q0NKGdmW87-Q2ToRfVongTH0UhwZs7A1yJiAWgA8O9rIrxPkps0zrBK2bFkXSuy4GlQM2DhWnY5Y_gkOmXHUKcmogBMbDVn_4OQj0IDnt4LKOtsE7Mb6CEkFku7uJ3o4XAnqrC9E8Wd0QkvhzFN7aczrhwjwzsflpUL2ecUZbAgDGI8rPrOQjG1rBsJZ-ARZ9zval7WqWEddgaMyuJOY0zLO2OWvHe9RLr-0eBxfCB6KE9-Q7XfNCeiPPM_qep40Y9gX3DnmXMB7a1HUhjXK660_-wmZDOCtKKq8kWPds6kWnvgPpJG9s94WKl6SVCuN6q9fP96yByyovauhjboKaKelc-xoTJvFXY6J_A2d7vAjIOlLB05ySCAsnN4NxKTlgt3iiE5ozy1ENIWUfcuyGl4Qmn97ufdIGVIaIjDtB_OWRQedp6jCenA9Yy_znNTCLf_XwSptY1IjNkuodqQzaDhJSwATW1bktT6kK-YHB1kEwPBOJu7tVQ0GPmE4vaAZuSWZftM.8KKH5X9d59fRvPDXp-nNGA";

                var queryParams = new Dictionary<String, String>();
                var headerParams = new Dictionary<String, String>()
                {
                   {"Authorization", "Bearer "+Access_token}
                };
                var formParams = new Dictionary<String, String>();
                var postBody = apiclient.Serialize(request); // http body (model) parameter

                // authentication setting, if any
                String[] authSettings = new String[] { };

                // make the HTTP request
                var response = await (ResponseConsultarDadosParcelaBilhetesContratado)apiclient.CallApi(path, HttpMethod.Post, queryParams, postBody, headerParams, formParams, authSettings);

                var resposta = new ResponseConsultarDadosParcelaBilhetesContratado();

                resposta = (ResponseConsultarDadosParcelaBilhetesContratado)apiclient.Deserialize(response.Return, typeof(ResponseConsultarDadosParcelaBilhetesContratado), response.Headers);

                return resposta;

            }

            [HttpPost("GerarEfetivacao")]
            /// <summary>
            ///  método de efetivação, produto negociavel
            /// </summary>
            /// <param name="body"></param>
            /// <returns>Sucess</returns>
            public Sucess GerarEfetivacaoPost([FromHeader] string Access_token, Body body)
            {

                var path = apiclient.BasePath + "/V2/prweb/PRRestService/APINegociaveis/v1/GerarEfetivacao";
                path = path.Replace("{format}", "json");

                var queryParams = new Dictionary<String, String>();
                var headerParams = new Dictionary<String, String>()
                {
                   {"Authorization", "Bearer " + Access_token}
                };
                var formParams = new Dictionary<String, String>();
                var fileParams = new Dictionary<String, FileParameter>();
                var postBody = apiclient.Serialize(body); // http body (model) parameter

                // authentication setting, if any
                String[] authSettings = new String[] { };

                // make the HTTP request
                RestResponse response = (RestResponse)apiclient.CallApi(path, HttpMethod.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

                var resposta = new Sucess();
                var erro = new ResultErrors();

                if (((int)response.StatusCode) >= 400)
                {
                    erro = JsonConvert.DeserializeObject<ResultErrors>(response.Content);

                    resposta.Result = new ResultErrorsInner()
                    {
                        CodeError = (erro != null ? erro.Result.CodeError : ((int)response.StatusCode).ToString()),
                        Description = (erro != null ? erro.Result.Description : response.StatusDescription)
                    };

                }
                else
                    resposta = (Sucess)apiclient.Deserialize(response.Content, typeof(Sucess), response.Headers);

                return resposta;

            }


        */

    }
}
