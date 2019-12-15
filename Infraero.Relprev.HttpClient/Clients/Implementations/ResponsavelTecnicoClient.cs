using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class ResponsavelTecnicoClient : RestClientAPI, IResponsavelTecnicoClient
    {
        public string Resource = "ResponsavelTecnico";

        /// <summary>
        /// Constructor
        /// </summary>
        public ResponsavelTecnicoClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public Task<long> CreateResponsavelTecnico(CreateResponsavelTecnicoCommand command)
        {
            return PostAsync<long>($"{Resource}/CreateResponsavelTecnico", command);
        }
        public GridResponsavelTecnico GetGridResponsavelTecnico()
        {
            return Get<GridResponsavelTecnico>($"{Resource}/GetGridResponsavelTecnico");
        }

        public ResponsavelTecnicoDto GetResponsavelTecnicoById(int id)
        {
            return Get<ResponsavelTecnicoDto>($"{Resource}/GetResponsavelTecnicoById/{id}");
        }

        public bool UpdateResponsavelTecnico(UpdateResponsavelTecnicoCommand command)
        {
            return Post<bool>($"{Resource}/UpdateResponsavelTecnico", command);
        }

        public bool DeleteResponsavelTecnico(int id)
        {
            return Post<bool>($"{Resource}/DeleteResponsavelTecnico", id);
        }
    }
}
