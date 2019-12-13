using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infraero.Relprev.HttpClient.Http
{
    public interface IClientSDK
    {
        void Delete(Uri uri, Dictionary<string, string> headers);

        Task DeleteAsync(Uri uri, Dictionary<string, string> headers);

        HttpResponseMessage Execute(Uri uri, HttpMethod method, object body, Dictionary<string, string> headers);

        Task<HttpResponseMessage> ExecuteAsync(Uri uri, HttpMethod method, object body, Dictionary<string, string> headers);

        TResponse Get<TResponse>(Uri uri, Dictionary<string, string> headers);

        Task<TResponse> GetAsync<TResponse>(Uri uri, Dictionary<string, string> headers);

        //TokenDTO GetToken(string username, string password);

        //Task<TokenDTO> GetTokenAsync(string username, string password);

        TBody Post<TBody>(Uri uri, TBody body, Dictionary<string, string> headers);

        TResponse Post<TBody, TResponse>(Uri uri, TBody body, Dictionary<string, string> headers);

        Task<TBody> PostAsync<TBody>(Uri uri, TBody body, Dictionary<string, string> headers);

        Task<TResponse> PostAsync<TBody, TResponse>(Uri uri, TBody body, Dictionary<string, string> headers);
    }
}
