using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.CreateVinculoResponsavelEmpresa;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Commands.DeleteVinculoResponsavelEmpresa;
using Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceVinculoResponsavelEmpresa = "VinculoResponsavelEmpresa";

        #region Main Methods

        public Task<long> CreateVinculoResponsavelEmpresa(CreateVinculoResponsavelEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/CreateVinculoResponsavelEmpresa"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteVinculoResponsavelEmpresa(DeleteVinculoResponsavelEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/DeleteVinculoResponsavelEmpresa"));
            return Post(requestUrl, command);
        }

        public GridVinculoResponsavelEmpresa GetGridVinculoResponsavelEmpresa()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/GetGridVinculoResponsavelEmpresa"));
            return Get<GridVinculoResponsavelEmpresa>(requestUrl);
        }

        public List<VinculoResponsavelEmpresaDto> GetVinculoResponsavelEmpresaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/GetVinculoResponsavelEmpresaAll/"));
            return Get<List<VinculoResponsavelEmpresaDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public VinculoResponsavelEmpresaDto GetVinculoResponsavelEmpresaById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/GetVinculoResponsavelEmpresaById/{id}"));
            return Get<VinculoResponsavelEmpresaDto>(requestUrl);
        }
        public Task<VinculoResponsavelEmpresaDto> ExistVinculo(CreateVinculoResponsavelEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceVinculoResponsavelEmpresa}/ExistVinculo"));
            return PostAsync<VinculoResponsavelEmpresaDto, CreateVinculoResponsavelEmpresaCommand>(requestUrl, command);
        }

        #endregion

    }
}