using System.Collections.Generic;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class RelatoClient : RestClientAPI, IRelatoClient
    {

        public string Resource = "Relato";

        /// <summary>
        /// Constructor
        /// </summary>
        public RelatoClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public long CreateRelato(CreateRelatoCommand command)
        {
            return Post<long>($"{Resource}/CreateRelato", command);
        }
        
        public GridRelato GetGridRelato()
        {
            return Get<GridRelato>($"{Resource}/GetGridRelato");
        }

        public RelatoDto GetRelatoById(int id)
        {
            return Get<RelatoDto>($"{Resource}/GetRelatoById/{id}");
        }
    }
}
