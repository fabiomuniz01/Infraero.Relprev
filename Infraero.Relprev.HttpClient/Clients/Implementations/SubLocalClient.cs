using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.DeleteSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class SubLocalClient : RestClientAPI, ISubLocalClient
    {
        public string Resource = "SubLocal";

        /// <summary>
        /// Constructor
        /// </summary>
        public SubLocalClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public long CreateSubLocal(CreateSubLocalCommand command)
        {
            return Post<long>($"{Resource}/CreateSubLocal", command);
        }
        public GridSubLocal GetGridSubLocal()
        {
            return Get<GridSubLocal>($"{Resource}/GetGridSubLocal");
        }

        public SubLocalDto GetSubLocalById(int id)
        {
            return Get<SubLocalDto>($"{Resource}/GetSubLocalById/{id}");
        }

        public bool UpdateSubLocal(UpdateSubLocalCommand command)
        {
            return Post<bool>($"{Resource}/UpdateSubLocal", command);
        }

        public bool DeleteSubLocal(DeleteSubLocalCommand id)
        {
            return Post<bool>($"{Resource}/DeleteSubLocal", id);
        }
    }
}
