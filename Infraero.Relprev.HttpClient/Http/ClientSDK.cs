//using Fabs.Application.DTO;
//using Fabs.Infrastructure.CrossCutting.Constants;
using Infraero.Relprev.CrossCutting.Serializater;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Infraero.Relprev.HttpClient.Http
{
    public class ClientSDK : IClientSDK
    {
        private readonly string _clientId;
        private readonly string _clientSecret;
        private readonly System.Net.Http.HttpClient _httpClient;
        private readonly IIdentity _identity;
        private readonly JsonSerializerSettings _jsonSerializerSettings;
        private readonly string _tokenUrl;

        //private TokenDTO token;

        public ClientSDK(string tokenUrl, string clientId, string clientSecret, IIdentity identity = null)
        {
            _httpClient = new System.Net.Http.HttpClient() { Timeout = TimeSpan.FromMinutes(10) };
            _tokenUrl = tokenUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
            _identity = identity;

            _jsonSerializerSettings = SerializerSettings.GetDefault();
        }

        public ClientSDK(System.Net.Http.HttpClient httpClient, JsonSerializerSettings jsonSerializerSettings)
        {
            _httpClient = httpClient;
            _jsonSerializerSettings = jsonSerializerSettings;
        }

        public void Delete(Uri uri, Dictionary<string, string> headers)
        {
            DeleteAsync(uri, headers).RunSynchronously();
        }

        public async Task DeleteAsync(Uri uri, Dictionary<string, string> headers)
        {
            using (HttpResponseMessage response = await ExecuteAsync(uri, HttpMethod.Delete, null, headers).ConfigureAwait(false))
            {
                await SerializeAsync(response).ConfigureAwait(false);
            }
        }

        public HttpResponseMessage Execute(Uri uri, HttpMethod method, object body, Dictionary<string, string> headers)
        {
            return ExecuteAsync(uri, method, body, headers).Result;
        }

        public async Task<HttpResponseMessage> ExecuteAsync(Uri uri, HttpMethod method, object body, Dictionary<string, string> headers)
        {
            var message = new HttpRequestMessage(method, uri);

            if (body != null)
            {
                if (body.GetType() != typeof(MultipartFormDataContent))
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(body), Encoding.UTF8, "application/json");
                }
                else
                {
                    message.Content = (MultipartFormDataContent)body;
                }
            }

            if (headers != null && headers.Any())
            {
                foreach (var header in headers)
                {
                    message.Headers.Add(header.Key, header.Value);
                }

                //if (token != null)
                //{
                //    message.Headers.Add("Authorization", "Bearer " + token.AccessToken);
                //}

                //if (_identity != null)
                //{
                //    var accessToken = ((ClaimsIdentity)_identity).FindFirst(f => f.Type == CustomClaimTypes.Token);
                //    if (accessToken != null)
                //    {
                //        message.Headers.Add("Authorization", "Bearer " + accessToken.Value);
                //    }
                //}
            }

            return await _httpClient.SendAsync(message, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
        }

        public TResponse Get<TResponse>(Uri uri, Dictionary<string, string> headers)
        {
            return GetAsync<TResponse>(uri, headers).Result;
        }

        public async Task<TResponse> GetAsync<TResponse>(Uri uri, Dictionary<string, string> headers)
        {
            using (HttpResponseMessage response = await ExecuteAsync(uri, HttpMethod.Get, null, headers).ConfigureAwait(false))
            {
                return await DeserializeAsync<TResponse>(response).ConfigureAwait(false);
            }
        }

        //public TokenDTO GetToken(string username, string password)
        //{
        //    HttpContent content = new FormUrlEncodedContent(new[]
        //    {
        //        new KeyValuePair<string, string>("client_id", _clientId),
        //        new KeyValuePair<string, string>("client_secret", _clientSecret),
        //        new KeyValuePair<string, string>("grant_type", "password"),
        //        new KeyValuePair<string, string>("username", username),
        //        new KeyValuePair<string, string>("password", password)
        //    });

        //    using (HttpResponseMessage response = _httpClient.PostAsync(_tokenUrl, content).ConfigureAwait(false).GetAwaiter().GetResult())
        //    {
        //        string resultContent = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            throw new AggregateException(resultContent);
        //        }

        //        token = JsonConvert.DeserializeObject<TokenDTO>(resultContent, _jsonSerializerSettings);

        //        return token;
        //    }
        //}

        //public async Task<TokenDTO> GetTokenAsync(string username, string password)
        //{
        //    HttpContent content = new FormUrlEncodedContent(new[]
        //    {
        //        new KeyValuePair<string, string>("client_id", _clientId),
        //        new KeyValuePair<string, string>("client_secret", _clientSecret),
        //        new KeyValuePair<string, string>("grant_type", "password"),
        //        new KeyValuePair<string, string>("username", username),
        //        new KeyValuePair<string, string>("password", password)
        //    });

        //    using (HttpResponseMessage response = await _httpClient.PostAsync(_tokenUrl, content).ConfigureAwait(false))
        //    {
        //        string resultContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        //        if (!response.IsSuccessStatusCode)
        //        {
        //            throw new AggregateException(resultContent);
        //        }

        //        token = JsonConvert.DeserializeObject<TokenDTO>(resultContent, _jsonSerializerSettings);

        //        return token;
        //    }
        //}

        public TBody Post<TBody>(Uri uri, TBody body, Dictionary<string, string> headers)
        {
            return PostAsync(uri, body, headers).Result;
        }

        public TResponse Post<TBody, TResponse>(Uri uri, TBody body, Dictionary<string, string> headers)
        {
            return PostAsync<TBody, TResponse>(uri, body, headers).Result;
        }

        public async Task<TBody> PostAsync<TBody>(Uri uri, TBody body, Dictionary<string, string> headers)
        {
            using (HttpResponseMessage response = await ExecuteAsync(uri, HttpMethod.Post, body, headers).ConfigureAwait(false))
            {
                return await DeserializeAsync<TBody>(response).ConfigureAwait(false);
            }
        }

        public async Task<TResponse> PostAsync<TBody, TResponse>(Uri uri, TBody body, Dictionary<string, string> headers)
        {
            using (HttpResponseMessage response = await ExecuteAsync(uri, HttpMethod.Post, body, headers).ConfigureAwait(false))
            {
                return await DeserializeAsync<TResponse>(response).ConfigureAwait(false);
            }
        }

        private TResponse Deserialize<TResponse>(HttpResponseMessage response)
        {
            Serialize(response);

            byte[] content = null;

            if (response.Content != null)
            {
                content = response.Content.ReadAsByteArrayAsync().Result;
            }

            if (content == null)
            {
                return default(TResponse);
            }

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ClientSDKError>(Encoding.Default.GetString(content));
                throw new AggregateException(error.Message);
            }

            return JsonConvert.DeserializeObject<TResponse>(Encoding.Default.GetString(content), _jsonSerializerSettings);
        }

        private async Task<TResponse> DeserializeAsync<TResponse>(HttpResponseMessage response)
        {
            await SerializeAsync(response).ConfigureAwait(false);

            byte[] content = null;

            if (response.Content != null)
            {
                content = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }

            if (content == null)
            {
                return default(TResponse);
            }

            if (!response.IsSuccessStatusCode)
            {
                var error = JsonConvert.DeserializeObject<ClientSDKError>(Encoding.UTF8.GetString(content));
                throw new AggregateException(error.Message);
            }
            var b = new bool();
            b = false;
            if (b)
            {
                return JsonConvert.DeserializeObject<TResponse>(Encoding.Default.GetString(content), _jsonSerializerSettings);

            }
            else
            {
                return JsonConvert.DeserializeObject<TResponse>(Encoding.UTF8.GetString(content), _jsonSerializerSettings);
            }

        }

        private void Serialize(HttpResponseMessage response)
        {
            if (response.Content != null)
            {
                byte[] content = response.Content.ReadAsByteArrayAsync().Result;
            }
        }

        private async Task SerializeAsync(HttpResponseMessage response)
        {
            if (response.Content != null)
            {
                byte[] content = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }
        }

        private struct ClientSDKError
        {
            public string Message { get; set; }
        }
    }
}
