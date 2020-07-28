using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.CreateVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Commands.DeleteVinculoUnidadeEmpresa;
using Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceVinculoUnidadeEmpresa = "VinculoUnidadeEmpresa";

        #region Main Methods

        public Task<long> CreateVinculoUnidadeEmpresa(CreateVinculoUnidadeEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/CreateVinculoUnidadeEmpresa"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteVinculoUnidadeEmpresa(DeleteVinculoUnidadeEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/DeleteVinculoUnidadeEmpresa"));
            return Post(requestUrl, command);
        }

        public GridVinculoUnidadeEmpresa GetGridVinculoUnidadeEmpresa()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/GetGridVinculoUnidadeEmpresa"));
            return Get<GridVinculoUnidadeEmpresa>(requestUrl);
        }

        public List<VinculoUnidadeEmpresaDto> GetVinculoUnidadeEmpresaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/GetVinculoUnidadeEmpresaAll/"));
            return Get<List<VinculoUnidadeEmpresaDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public VinculoUnidadeEmpresaDto GetVinculoUnidadeEmpresaById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/GetVinculoUnidadeEmpresaById/{id}"));
            return Get<VinculoUnidadeEmpresaDto>(requestUrl);
        }
        public Task<VinculoUnidadeEmpresaDto> ExistVinculo(CreateVinculoUnidadeEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoUnidadeEmpresa}/ExistVinculo"));
            return PostAsync<VinculoUnidadeEmpresaDto, CreateVinculoUnidadeEmpresaCommand>(requestUrl, command);
        }

        #endregion

    }
}