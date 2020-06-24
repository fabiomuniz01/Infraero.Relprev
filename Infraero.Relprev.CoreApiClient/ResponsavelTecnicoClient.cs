using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceResponsavelTecnico = "ResponsavelTecnico";

        #region Main Methods

        public Task<long> CreateResponsavelTecnico(CreateResponsavelTecnicoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/CreateResponsavelTecnico"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateResponsavelTecnico(UpdateResponsavelTecnicoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/UpdateResponsavelTecnico"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteResponsavelTecnico(DeleteResponsavelTecnicoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/DeleteResponsavelTecnico"));
            return Post(requestUrl, command);
        }

        public GridResponsavelTecnico GetGridResponsavelTecnico()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/GetGridResponsavelTecnico"));
            return Get<GridResponsavelTecnico>(requestUrl);
        }

        public List<ResponsavelTecnicoDto> GetResponsavelTecnicoAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/GetResponsavelTecnicoAll/"));
            return Get<List<ResponsavelTecnicoDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public ResponsavelTecnicoDto GetResponsavelTecnicoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/GetResponsavelTecnicoById/{id}"));
            return Get<ResponsavelTecnicoDto>(requestUrl);
        }

        public List<ResponsavelTecnicoDto> GetResponsavelTecnicoByIdEmpresa(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/GetResponsavelTecnicoByIdEmpresa/{id}"));
            return Get<List<ResponsavelTecnicoDto>>(requestUrl);
        }

        public Task<ResponsavelTecnicoDto> GetResponsavelByCpf(string cpf)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceResponsavelTecnico}/GetResponsavelByCpf"));
            return PostAsync<ResponsavelTecnicoDto, string>(requestUrl, cpf);
        }

        #endregion

    }
}