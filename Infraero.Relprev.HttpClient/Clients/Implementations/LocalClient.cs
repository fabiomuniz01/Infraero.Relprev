using System.Collections.Generic;
using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class LocalClient : RestClientAPI, ILocalClient
    {

        public string Resource = "Local";

        /// <summary>
        /// Constructor
        /// </summary>
        public LocalClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public long CreateLocal(CreateLocalCommand command)
        {
            return Post<long>($"{Resource}/CreateLocal", command);
        }
        public GridLocal GetGridLocal()
        {
            return Get<GridLocal>($"{Resource}/GetGridLocal");
        }

        public LocalDto GetLocalById(int id)
        {
            return Get<LocalDto>($"{Resource}/GetLocalById/{id}");
        }

        public bool UpdateLocal(UpdateLocalCommand command)
        {
            return Post<bool>($"{Resource}/UpdateLocal", command);
        }

        public bool DeleteLocal(DeleteLocalCommand command)
        {
            return Post<bool>($"{Resource}/DeleteLocal", command);
        }

        public List<LocalDto> GetLocalAll()
        {
            return Get<List<LocalDto>>($"{Resource}/GetLocalAll");
        }

    }
}
