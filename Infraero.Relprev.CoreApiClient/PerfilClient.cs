using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Modulo.Queries.GetModulos;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourcePerfil = "Perfil";

        #region Main Methods

        public Task<long> CreatePerfil(CreatePerfilCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/CreatePerfil"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdatePerfil(UpdatePerfilCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/UpdatePerfil"));
            return Post(requestUrl, command);
        }

        public Task<long> DeletePerfil(DeletePerfilCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/DeletePerfil"));
            return Post(requestUrl, command);
        }

        public GridPerfil GetGridPerfil()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/GetGridPerfil"));
            return Get<GridPerfil>(requestUrl);
        }

        public List<PerfilDto> GetPerfilAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/GetPerfilAll/"));
            return Get<List<PerfilDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public PerfilDto GetPerfilById(string id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/GetPerfilById/{id}"));
            return Get<PerfilDto>(requestUrl);
        }
        public List<ModuloDto> GetModuloAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourcePerfil}/GetModuloAll"));
            return Get<List<ModuloDto>>(requestUrl);
        }

        #endregion
        
    }
}