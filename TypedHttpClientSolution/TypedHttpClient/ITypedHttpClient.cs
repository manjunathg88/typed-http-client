namespace TypedHttpClientNamespace
{
    public interface ITypedHttpClient
    {
        Task<HttpResponseMessage> Execute(string uri, HttpMethod method, HttpContent? payload=null);
    }
}
