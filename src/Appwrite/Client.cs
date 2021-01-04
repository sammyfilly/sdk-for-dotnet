using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Client
    {
        
        private readonly HttpClient http;

        private readonly Dictionary<string, string> headers;

        private readonly Dictionary<string, string> config;

        private string endPoint;
        
        private bool selfSigned;
        
        CookieContainer cookieJar = new CookieContainer();

        public Client() : this("https://appwrite.io/v1", false, new HttpClient())
        {

        }

        public Client(string endPoint, bool selfSigned, HttpClient http)
        {
            this.endPoint = endPoint;
            this.selfSigned = selfSigned;
            this.headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" },
                { "x-sdk-version", "appwrite:csharp:0.0.1" }
            };
            this.config = new Dictionary<string, string>();
            this.http = http;

            // coockie container ??                     
        }

        public Client SetSelfSigned(bool selfSigned)
        {
            this.selfSigned = selfSigned;
            return this;
        }

        public Client SetEndPoint(string endPoint)
        {
            this.endPoint = endPoint;
            return this;
        }

        public string GetEndPoint()
        {
            return endPoint;
        }

        public Dictionary<string, string> GetConfig()
        {
            return config;
        }


        /// Your project ID
        public Client SetProject(string value) {
            config.Add("project", value);
            AddHeader("X-Appwrite-Project", value);
            return this;
        }

        /// Your secret API key
        public Client SetKey(string value) {
            config.Add("key", value);
            AddHeader("X-Appwrite-Key", value);
            return this;
        }

        public Client SetLocale(string value) {
            config.Add("locale", value);
            AddHeader("X-Appwrite-Locale", value);
            return this;
        }



        public Client AddHeader(String key, String value)
        {
            headers.Add(key, value);
            return this;
        }

        public async Task<HttpResponseMessage> Call(string method, string path, Dictionary<string, string> headers, Dictionary<string, object> parameters)
        {
            if (selfSigned)
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            }

            bool methodGet = "GET".Equals(method, StringComparison.InvariantCultureIgnoreCase);

            string queryString = methodGet ? "?" + parameters.ToQueryString() : string.Empty;

            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(method), endPoint + path + queryString);

            if ("multipart/form-data".Equals(headers["content-type"], StringComparison.InvariantCultureIgnoreCase))
            {


                MultipartFormDataContent form = new MultipartFormDataContent();

                foreach (var parameter in parameters)
                {
                    if (parameter.Key == "file")
                    {
                        FileInfo fi = parameters["file"] as FileInfo;

                        var file = File.ReadAllBytes(fi.FullName);

                        form.Add(new ByteArrayContent(file, 0, file.Length), "file", fi.Name);
                    }
                    else
                    {
                        form.Add(new StringContent(parameter.Key), parameter.Value?.ToString());
                    }
                }
                request.Content = form;

            }
            else if (!methodGet)
            {
                string body = parameters.ToJson();

                request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            }

            foreach (var header in this.headers)
            {
                if (header.Key.Equals("content-type", StringComparison.InvariantCultureIgnoreCase))
                {
                    http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(header.Value));
                }
                else
                {
                    http.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            foreach (var header in headers)
            {
                if (header.Key.Equals("content-type", StringComparison.InvariantCultureIgnoreCase))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(header.Value));
                }
                else
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            HttpResponseMessage httpResponseMessage = await http.SendAsync(request);

            return httpResponseMessage;
        }

    }
}
