using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class UsuarioClient : RestClientAPI, IUsuarioClient
    {
        public string Resource = "Usuario";

        /// <summary>
        /// Constructor
        /// </summary>
        public UsuarioClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public Task<long> CreateUsuario(CreateUsuarioCommand command)
        {
            return PostAsync<long>($"{Resource}/CreateUsuario", command);
        }
        public GridUsuario GetGridUsuario()
        {
            return Get<GridUsuario>($"{Resource}/GetGridUsuario");
        }

        public UsuarioDto GetUsuarioById(int id)
        {
            return Get<UsuarioDto>($"{Resource}/GetUsuarioById/{id}");
        }

        public bool UpdateUsuario(UpdateUsuarioCommand command)
        {
            return Post<bool>($"{Resource}/UpdateUsuario", command);
        }

        public bool DeleteUsuario(int id)
        {
            return Post<bool>($"{Resource}/DeleteUsuario", id);
        }
    }
}
