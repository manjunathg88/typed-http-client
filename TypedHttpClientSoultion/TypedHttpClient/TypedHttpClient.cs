using System.Net.Http.Headers;

namespace TypedHttpClientNamespace
{
    public class TypedHttpClient : ITypedHttpClient
    {
        private readonly HttpClient _httpClient;

        public TypedHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HttpResponseMessage> Execute(string uri, HttpMethod method, HttpContent? payload)
        {
            var request = new HttpRequestMessage(method, uri)
            {
                Content = payload
            };

            return await _httpClient.SendAsync(request);
        }
    }
}
