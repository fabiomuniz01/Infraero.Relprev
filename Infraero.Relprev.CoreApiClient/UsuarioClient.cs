using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Application.Usuario.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuario.Commands.DeleteUsuario;
using Infraero.Relprev.Application.Usuario.Commands.UpdateUsuario;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceUsuario = "Usuario";

        #region Main Methods

        public Task<long> CreateUsuario(CreateUsuarioCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/CreateUsuario"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateUsuario(UpdateUsuarioCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/UpdateUsuario"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteUsuario(DeleteUsuarioCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/DeleteUsuario"));
            return Post(requestUrl, command);
        }

        public GridUsuario GetGridUsuario()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/GetGridUsuario"));
            return Get<GridUsuario>(requestUrl);
        }

        public List<UsuarioDto> GetUsuarioAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/GetUsuarioAll/"));
            return Get<List<UsuarioDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public UsuarioDto GetUsuarioById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/GetUsuarioById/{id}"));
            return Get<UsuarioDto>(requestUrl);
        }

        public Task<UsuarioDto> GetUsuarioByCpf(string cpf)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUsuario}/GetUsuarioByCpf"));
            return PostAsync<UsuarioDto, string>(requestUrl, cpf);
        }

        #endregion

    }
}