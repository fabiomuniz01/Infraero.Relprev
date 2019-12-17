using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class SubAssuntoClient : RestClientAPI, ISubAssuntoClient
    {
        public string Resource = "SubAssunto";

        /// <summary>
        /// Constructor
        /// </summary>
        public SubAssuntoClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public long CreateSubAssunto(CreateSubAssuntoCommand command)
        {
            return Post<long>($"{Resource}/CreateSubAssunto", command);
        }
        public GridSubAssunto GetGridSubAssunto()
        {
            return Get<GridSubAssunto>($"{Resource}/GetGridSubAssunto");
        }

        public SubAssuntoDto GetSubAssuntoById(int id)
        {
            return Get<SubAssuntoDto>($"{Resource}/GetSubAssuntoById/{id}");
        }

        public bool UpdateSubAssunto(UpdateSubAssuntoCommand command)
        {
            return Post<bool>($"{Resource}/UpdateSubAssunto", command);
        }

        public bool DeleteSubAssunto(int id)
        {
            return Post<bool>($"{Resource}/DeleteSubAssunto", id);
        }
    }
}
