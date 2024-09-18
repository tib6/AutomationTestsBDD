namespace AutomationTestsBDD.Utility
{
    public sealed class HttpClientBasic
    {
        private static readonly Lazy<HttpClient> LazyHttpClient = new Lazy<HttpClient>(() =>
        {
            var httpClientHandler = new HttpClientHandler
            {
                Credentials = new NetworkCredential("tiberiu.bucur", ""),
                PreAuthenticate = true,
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
            };
            var httpClient = new HttpClient(httpClientHandler) { Timeout = new TimeSpan(0, 0, 120) };
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        });
        
        public static HttpClient Instance => LazyHttpClient.Value;

        private HttpClientBasic() { }

        //Get Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendGetAsync(url, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, HttpContent content, HttpStatusCode status)
        {
            return await SendGetAsync(url, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, HttpContent content)
        {
            return await SendGetAsync(url, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendGetAsync(url, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendGetAsync(url, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url, HttpStatusCode status)
        {
            return await SendGetAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendGetAsync(Uri url)
        {
            return await SendGetAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Post Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPostAsync(url, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, HttpContent content, HttpStatusCode status)
        {
            return await SendPostAsync(url, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, HttpContent content)
        {
            return await SendPostAsync(url, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendPostAsync(url, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPostAsync(url, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url, HttpStatusCode status)
        {
            return await SendPostAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPostAsync(Uri url)
        {
            return await SendPostAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Put Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPutAsync(url, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, HttpContent content, HttpStatusCode status)
        {
            return await SendPutAsync(url, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, HttpContent content)
        {
            return await SendPutAsync(url, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendPutAsync(url, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPutAsync(url, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url, HttpStatusCode status)
        {
            return await SendPutAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPutAsync(Uri url)
        {
            return await SendPutAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Patch Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPatchAsync(url, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, HttpContent content, HttpStatusCode status)
        {
            return await SendPatchAsync(url, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, HttpContent content)
        {
            return await SendPatchAsync(url, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendPatchAsync(url, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendPatchAsync(url, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url, HttpStatusCode status)
        {
            return await SendPatchAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendPatchAsync(Uri url)
        {
            return await SendPatchAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Delete Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendDeleteAsync(url, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, HttpContent content, HttpStatusCode status)
        {
            return await SendDeleteAsync(url, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, HttpContent content)
        {
            return await SendDeleteAsync(url, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendDeleteAsync(url, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendDeleteAsync(url, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url, HttpStatusCode status)
        {
            return await SendDeleteAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendDeleteAsync(Uri url)
        {
            return await SendDeleteAsync(url, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Send Async With HttpResponseMessage
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, HttpContent content, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(method, url);
            if (content != null)
            {
                request.Content = content;
            }
            modifyHeaders?.Invoke(request.Headers);
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return response;
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, HttpContent content, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendAsync(url, method, content, modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, HttpContent content, HttpStatusCode status)
        {
            return await SendAsync(url, method, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, HttpContent content)
        {
            return await SendAsync(url, method, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, Action<HttpRequestHeaders> modifyHeaders, HttpStatusCode status)
        {
            return await SendAsync(url, method, new StringContent(""), modifyHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, Action<HttpRequestHeaders> modifyHeaders)
        {
            return await SendAsync(url, method, new StringContent(""), modifyHeaders, HttpStatusCode.OK);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method, HttpStatusCode status)
        {
            return await SendAsync(url, method, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<HttpResponseMessage> SendAsync(Uri url, HttpMethod method)
        {
            return await SendAsync(url, method, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Get Async with Json Body Response
        public static async Task<T> SendGetAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendGetAsync<T>(uri, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, HttpContent content, HttpStatusCode status)
        {
            return await SendGetAsync<T>(uri, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, HttpContent content)
        {
            return await SendGetAsync<T>(uri, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendGetAsync<T>(uri, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction)
        {
            return await SendGetAsync<T>(uri, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri, HttpStatusCode status)
        {
            return await SendGetAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendGetAsync<T>(Uri uri)
        {
            return await SendGetAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);

        }

        //Post Async with Json Body Response
        public static async Task<T> SendPostAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPostAsync<T>(uri, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, HttpContent content, HttpStatusCode status)
        {
            return await SendPostAsync<T>(uri, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, HttpContent content)
        {
            return await SendPostAsync<T>(uri, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendPostAsync<T>(uri, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPostAsync<T>(uri, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri, HttpStatusCode status)
        {
            return await SendPostAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPostAsync<T>(Uri uri)
        {
            return await SendPostAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Put Async with Json Body Response
        public static async Task<T> SendPutAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPutAsync<T>(uri, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, HttpContent content, HttpStatusCode status)
        {
            return await SendPutAsync<T>(uri, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, HttpContent content)
        {
            return await SendPutAsync<T>(uri, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendPutAsync<T>(uri, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPutAsync<T>(uri, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri, HttpStatusCode status)
        {
            return await SendPutAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPutAsync<T>(Uri uri)
        {
            return await SendPutAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Patch Async with Json Body Response
        public static async Task<T> SendPatchAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPatchAsync<T>(uri, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, HttpContent content, HttpStatusCode status)
        {
            return await SendPatchAsync<T>(uri, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, HttpContent content)
        {
            return await SendPatchAsync<T>(uri, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendPatchAsync<T>(uri, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction)
        {
            return await SendPatchAsync<T>(uri, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri, HttpStatusCode status)
        {
            return await SendPatchAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendPatchAsync<T>(Uri uri)
        {
            return await SendPatchAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Delete Async with Json Body Response
        public static async Task<T> SendDeleteAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendDeleteAsync<T>(uri, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, HttpContent content, HttpStatusCode status)
        {
            return await SendDeleteAsync<T>(uri, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, HttpContent content)
        {
            return await SendDeleteAsync<T>(uri, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendDeleteAsync<T>(uri, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, Action<HttpRequestHeaders> headersAction)
        {
            return await SendDeleteAsync<T>(uri, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri, HttpStatusCode status)
        {
            return await SendDeleteAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendDeleteAsync<T>(Uri uri)
        {
            return await SendDeleteAsync<T>(uri, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //Send Async with Json Body Response
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, HttpContent content, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            var request = new HttpRequestMessage(method, uri);
            headersAction?.Invoke(request.Headers);
            if (content != null)
            {
                request.Content = content;
            }
            var response = await Instance.SendAsync(request);
            Assert.That(response.StatusCode, Is.EqualTo(status));
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, HttpContent content, Action<HttpRequestHeaders> headersAction)
        {
            return await SendAsync<T>(uri, method, content, headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, HttpContent content, HttpStatusCode status)
        {
            return await SendAsync<T>(uri, method, content, HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, HttpContent content)
        {
            return await SendAsync<T>(uri, method, content, HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, Action<HttpRequestHeaders> headersAction, HttpStatusCode status)
        {
            return await SendAsync<T>(uri, method, new StringContent(""), headersAction, status);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, Action<HttpRequestHeaders> headersAction)
        {
            return await SendAsync<T>(uri, method, new StringContent(""), headersAction, HttpStatusCode.OK);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method, HttpStatusCode status)
        {
            return await SendAsync<T>(uri, method, new StringContent(""), HeaderBuilder.JsonHeaders, status);
        }
        public static async Task<T> SendAsync<T>(Uri uri, HttpMethod method)
        {
            return await SendAsync<T>(uri, method, new StringContent(""), HeaderBuilder.JsonHeaders, HttpStatusCode.OK);
        }

        //General Methods
        public static async Task<T> ReadAsync<T>(string filePath)
        {
            using FileStream stream = File.OpenRead(filePath);
            return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream);
        }
    }
}
