
using Infraero.Relprev.HttpClient.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public abstract class RestClientAPI
    {
        public RestClientAPI(string endpoint, IClientSDK httpSdkClient)
        {
            Endpoint = endpoint;
            HttpSDKClient = httpSdkClient;
        }

        protected string Endpoint { get; }

        protected Dictionary<string, string> Headers
        {
            get
            {
                return new Dictionary<string, string>()
                {
                    { "Accept", "application/json" }
                };
            }
        }

        protected IClientSDK HttpSDKClient { get; }

        public void Delete(string url, string body)
        {
            HttpSDKClient.Delete(GenerateUri(url), Headers);
        }

        public async Task DeleteAsync(string url, string body)
        {
            await HttpSDKClient.DeleteAsync(GenerateUri(url), Headers).ConfigureAwait(false);
        }

        public T Get<T>(string url)
        {
            var uri = GenerateUri(url);
            return HttpSDKClient.Get<T>(uri, Headers);
        }

        public async Task<T> GetAsync<T>(string url)
        {
            var uri = GenerateUri(url);
            return await HttpSDKClient.GetAsync<T>(uri, Headers).ConfigureAwait(false);
        }

        public void Post(string url, object body)
        {
            HttpSDKClient.Post(GenerateUri(url), body, Headers);
        }

        public T Post<T>(string url, object body)
        {
            return HttpSDKClient.Post<object, T>(GenerateUri(url), body, Headers);
        }

        public async Task PostAsync(string url, object body)
        {
            await HttpSDKClient.PostAsync(GenerateUri(url), body, Headers).ConfigureAwait(false);
        }

        public async Task<T> PostAsync<T>(string url, object body)
        {
            return await HttpSDKClient.PostAsync<object, T>(GenerateUri(url), body, Headers).ConfigureAwait(false);
        }

        private Uri GenerateUri(string url)
        {
            return new Uri($"{Endpoint}/api/{url}");
        }
    }
}
