using System;
using System.IO;
using System.Net.Http;

namespace Litehtml.Services
{
    public class HttpService
    {
        readonly HttpClient _client;

        public HttpService(string useragent)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", useragent);
        }

        public HttpResponseMessage Get(string url)
        {
            try { return _client.GetAsync(url).Result; }
            catch { return null; }
        }

        public Stream GetStream(string url)
        {
            try { return _client.GetStreamAsync(url).Result; }
            catch { return null; }
        }

        public void GetPromise(string url, Action<HttpResponseMessage> success, Action<string> error)
        {
            var t = _client.GetAsync(url);
            t.Wait();
            if (t.IsCompleted) success(t.Result);
            else error(t.IsFaulted ? t.Exception.Message : "Error");
        }

        public void Stop() => _client.CancelPendingRequests();
    }
}