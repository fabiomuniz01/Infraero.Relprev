using System.Collections.Generic;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
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

        public bool CreatePerfil(CreatePerfilCommand command)
        {
            return Post<bool>($"{Resource}/CreatePerfil", command);
        }
        public GridPerfil GetGridPerfil()
        {
            return Get<GridPerfil>($"{Resource}/GetGridPerfil");
        }

        public PerfilDto GetPerfilById(string id)
        {
            return Get<PerfilDto>($"{Resource}/GetPerfilById/{id}");
        }

        public bool UpdatePerfil(UpdatePerfilCommand command)
        {
            return Post<bool>($"{Resource}/UpdatePerfil", command);
        }

        public bool DeletePerfil(DeletePerfilCommand command)
        {
            return Post<bool>($"{Resource}/DeletePerfil", command);
        }

        public List<PerfilDto> GetPerfilAll()
        {
            return Get<List<PerfilDto>>($"{Resource}/GetPerfilAll");
        }
    }
}
