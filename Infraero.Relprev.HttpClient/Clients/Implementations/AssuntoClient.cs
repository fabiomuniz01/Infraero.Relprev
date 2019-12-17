using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
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

        public long CreateAssunto(CreateAssuntoCommand command)
        {
            return Post<long>($"{Resource}/CreateAssunto", command);
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

        public List<AssuntoDto> GetAssuntoAll()
        {
            return Get<List<AssuntoDto>>($"{Resource}/GetAssuntoAll");
        }
    }
}
