using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;
using System.Threading.Tasks;

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

        public Task<long> CreateLocal(CreateLocalCommand command)
        {
            return PostAsync<long>($"{Resource}/CreateLocal", command);
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

        public bool DeleteLocal(int id)
        {
            return Post<bool>($"{Resource}/DeleteLocal", id);
        }

    }
}
