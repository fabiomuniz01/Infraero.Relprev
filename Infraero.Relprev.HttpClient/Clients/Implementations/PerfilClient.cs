using System.Collections.Generic;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class PerfilClient : RestClientAPI, IPerfilClient
    {

        public string Resource = "Perfil";

        /// <summary>
        /// Constructor
        /// </summary>
        public PerfilClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }


        public List<PerfilDto> GetPerfilAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
