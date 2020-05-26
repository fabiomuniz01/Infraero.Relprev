using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.ConfigurarAmbiente.Queries.GetConfigurarAmbientes;
using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.CreateConfigurarAmbiente;
using Infraero.Relprev.Application.ConfigurarAmbiente.Commands.UpdateConfigurarAmbiente;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceConfigurarAmbiente = "ConfigurarAmbiente";

        #region Main Methods

        public Task<long> CreateConfigurarAmbiente(CreateConfigurarAmbienteCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceConfigurarAmbiente}/CreateConfigurarAmbiente"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateConfigurarAmbiente(UpdateConfigurarAmbienteCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceConfigurarAmbiente}/UpdateConfigurarAmbiente"));
            return Post(requestUrl, command);
        }

        #endregion

        #region Methods

        public ConfigurarAmbienteDto GetConfigurarAmbienteById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceConfigurarAmbiente}/GetConfigurarAmbienteById/{id}"));
            return Get<ConfigurarAmbienteDto>(requestUrl);
        }

        #endregion

    }
}