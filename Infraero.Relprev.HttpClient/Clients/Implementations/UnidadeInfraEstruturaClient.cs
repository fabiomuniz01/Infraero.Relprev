using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class UnidadeInfraEstruturaClient : RestClientAPI, IUnidadeInfraEstruturaClient
    {
        public string Resource = "UnidadeInfraEstrutura";

        /// <summary>
        /// Constructor
        /// </summary>
        public UnidadeInfraEstruturaClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public long CreateUnidadeInfraEstrutura(CreateUnidadeInfraEstruturaCommand command)
        {
            return Post<long>($"{Resource}/CreateUnidadeInfraEstrutura", command);
        }
        public GridUnidadeInfraEstrutura GetGridUnidadeInfraEstrutura()
        {
            return Get<GridUnidadeInfraEstrutura>($"{Resource}/GetGridUnidadeInfraEstrutura");
        }

        public UnidadeInfraEstruturaDto GetUnidadeInfraEstruturaById(int id)
        {
            return Get<UnidadeInfraEstruturaDto>($"{Resource}/GetUnidadeInfraEstruturaById/{id}");
        }

        public bool UpdateUnidadeInfraEstrutura(UpdateUnidadeInfraEstruturaCommand command)
        {
            return Post<bool>($"{Resource}/UpdateUnidadeInfraEstrutura", command);
        }

        public bool DeleteUnidadeInfraEstrutura(int id)
        {
            return Post<bool>($"{Resource}/DeleteUnidadeInfraEstrutura", id);
        }

        public List<UnidadeInfraEstruturaDto> GetUnidadeInfraEstruturaAll()
        {
            return Get<List<UnidadeInfraEstruturaDto>>($"{Resource}/GetUnidadeInfraEstruturaAll/");
        }
    }
}
