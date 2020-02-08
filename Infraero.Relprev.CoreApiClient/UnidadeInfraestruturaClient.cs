using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.DeleteUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceUnidadeInfraEstrutura = "UnidadeInfraEstrutura";

        #region Main Methods

        public Task<long> CreateUnidadeInfraEstrutura(CreateUnidadeInfraEstruturaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/CreateUnidadeInfraEstrutura"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateUnidadeInfraEstrutura(UpdateUnidadeInfraEstruturaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/UpdateUnidadeInfraEstrutura"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteUnidadeInfraEstrutura(DeleteUnidadeInfraEstruturaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/DeleteUnidadeInfraEstrutura"));
            return Post(requestUrl, command);
        }

        public GridUnidadeInfraEstrutura GetGridUnidadeInfraEstrutura()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/GetGridUnidadeInfraEstrutura"));
            return Get<GridUnidadeInfraEstrutura>(requestUrl);
        }

        public List<UnidadeInfraEstruturaDto> GetUnidadeInfraEstruturaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/GetUnidadeInfraEstruturaAll/"));
            return Get<List<UnidadeInfraEstruturaDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public UnidadeInfraEstruturaDto GetUnidadeInfraEstruturaById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/GetUnidadeInfraEstruturaById/{id}"));
            return Get<UnidadeInfraEstruturaDto>(requestUrl);
        }

        public List<UnidadeInfraEstruturaDto.Dependencia> GetDependenciaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceUnidadeInfraEstrutura}/GetDependenciaAll"));
            return Get<List<UnidadeInfraEstruturaDto.Dependencia>>(requestUrl);
        }

        #endregion
        
    }
}