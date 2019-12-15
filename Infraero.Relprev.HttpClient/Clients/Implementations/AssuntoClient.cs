using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assuntos.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assuntos.Commands.UpdateAssunto;
using Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class AssuntoClient : RestClientAPI, IAssuntoClient
    {
        public string Resource = "Assunto";

        /// <summary>
        /// Constructor
        /// </summary>
        public AssuntoClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public Task<long> CreateAssunto(CreateAssuntoCommand command)
        {
            return PostAsync<long>($"{Resource}/CreateAssunto", command);
        }
        public GridAssunto GetGridAssunto()
        {
            return Get<GridAssunto>($"{Resource}/GetGridAssunto");
        }

        public AssuntoDto GetAssuntoById(int id)
        {
            return Get<AssuntoDto>($"{Resource}/GetAssuntoById/{id}");
        }

        public bool UpdateAssunto(UpdateAssuntoCommand command)
        {
            return Post<bool>($"{Resource}/UpdateAssunto", command);
        }

        public bool DeleteAssunto(int id)
        {
            return Post<bool>($"{Resource}/DeleteAssunto", id);
        }
    }
}
