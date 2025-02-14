using APICalculo.Model;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;

namespace APICalculo.Common
{
    /// <summary>
    /// Http Util
    /// </summary>
    public class HttpUtil
    {
        private const string contentMediaTypeJson = "application/json";
        private const string contentMediaTypeText = "text/plain";
        private const string JsonContentType = "application/json";

        HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// HttpUtil - Contructor
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="logger"></param>
        public HttpUtil()
        {
        }

        #region Metodos Genericos

        /// <summary>
        /// CallServiceAsync
        /// </summary>
        /// <typeparam name="Request"></typeparam>
        /// <typeparam name="Response"></typeparam>
        /// <param name="request"></param>
        /// <param name="uri"></param>
        /// <param name="httpMethod"></param>
        /// <param name="hearder"></param>
        /// <returns></returns>
        public async Task<Response> CallServiceAsync<Request, Response>(Request? request, Uri uri, HttpMethod httpMethod, Dictionary<string, string> formParams, Dictionary<string, string> hearder) where Response : ResponseErrors, new()
        {
            try
            {
                var requestContent = SerializeObject(request);

                var httpRequest = ToRequestMessage(endpoint: uri, method: httpMethod, requestContent: requestContent, charset: null, formParams: formParams, headers: hearder);

                var objectResponse = await ExecuteAsync<Response>(httpRequest);

                return objectResponse;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private static HttpRequestMessage ToRequestMessage(Uri endpoint, HttpMethod method, string requestContent, Encoding charset = null, Dictionary<string, string> formParams = null, Dictionary<string, string> headers = null)
        {
            if (charset == null) charset = Encoding.UTF8;
            var uriGet = new Uri(BuildQueryString(requestContent, endpoint.AbsoluteUri));

            var httpRequest = new HttpRequestMessage()
            {
                RequestUri = method != HttpMethod.Get ? endpoint : uriGet,
                Method = method,
                Headers =
                {
                    {HttpRequestHeader.Accept.ToString(), contentMediaTypeJson }
                },
                Content = new StringContent(requestContent, charset, contentMediaTypeText),
            };

            if (endpoint.AbsolutePath.Contains("/V2/Auth"))
            {
                httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                httpRequest.Content = new FormUrlEncodedContent(formParams);
            }
            else
            {
                // inclusao no header
                if (headers != null)
                    httpRequest = AddHeaders(httpRequest, headers);


                if (charset == null)
                    httpRequest.Content.Headers.ContentType = new MediaTypeHeaderValue(contentMediaTypeText);
            }


            httpRequest.Headers.Accept.ParseAdd(JsonContentType);
            return httpRequest;
        }

        private async Task<TResponse> ExecuteAsync<TResponse>(HttpRequestMessage httpRequestMessage) where TResponse : ResponseErrors, new()
        {
            try
            {
                var retorno = new TResponse();

                var httpResponse = _httpClient.SendAsync(httpRequestMessage).Result;

                if (httpResponse.IsSuccessStatusCode)   
                {
                    retorno = DeserializeObject<TResponse>(httpResponse);
                }
                else
                {

                    retorno.Errors = new ResponseErrorsInner()
                    {
                        CodeError = ((int)httpResponse.StatusCode).ToString(),
                        Message = httpResponse.StatusCode.ToString()
                    };

                }



                return retorno;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private TResponse DeserializeObject<TResponse>(HttpResponseMessage httpResponse)
        {
            var retorno = DeserializeObjectAsync<TResponse>(httpResponse).GetAwaiter().GetResult();
            return retorno;
        }

        private async static Task<TResponse> DeserializeObjectAsync<TResponse>(HttpResponseMessage httpResponse)
        {
            if (httpResponse.Content == null) return await Task.Run(() => { return default(TResponse); });

            var dataAsString = await httpResponse.Content.ReadAsStringAsync();

            var resultData = JsonConvert.DeserializeObject<TResponse>(dataAsString);

            return resultData;
        }

        /// <summary>
        /// AddHeaders
        /// </summary>
        /// <param name="request"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public static HttpRequestMessage AddHeaders(HttpRequestMessage? request, Dictionary<string, string> headers)
        {
            foreach (var item in headers.Keys)
            {
                if (item.Equals("Authorization"))
                    request.Headers.Add(item, headers[item]);
                else
                    request.Content.Headers.Add(item, headers[item]);
            }
            return request;
        }

        private static string SerializeObject(object request)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.SerializeObject(request, serializerSettings);
        }

        private static string BuildQueryString(string request, string endpoint)
        {
            var responsebuild = string.Concat(endpoint);
            if (request != "null")
            {
                return string.Concat(endpoint, "/", request);
            }
            return responsebuild;
        }

        #endregion
    }
}