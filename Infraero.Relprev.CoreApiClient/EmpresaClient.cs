using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceEmpresa = "Empresa";

        #region Main Methods

        public Task<long> CreateEmpresa(CreateEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/CreateEmpresa"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateEmpresa(UpdateEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/UpdateEmpresa"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteEmpresa(DeleteEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/DeleteEmpresa"));
            return Post(requestUrl, command);
        }

        public GridEmpresa GetGridEmpresa()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetGridEmpresa"));
            return Get<GridEmpresa>(requestUrl);
        }

        public List<EmpresaDto> GetEmpresaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetEmpresaAll/"));
            return Get<List<EmpresaDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public EmpresaDto GetEmpresaById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetEmpresaById/{id}"));
            return Get<EmpresaDto>(requestUrl);
        }

        #endregion

    }
}