using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.Relato.Commands.CancelRelato;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceRelato = "Relato";

        #region Main Methods

        public Task<long> CreateRelato(CreateRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/CreateRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateRelato(UpdateRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/UpdateRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> CancelRelato(CancelRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/CancelRelato"));
            return Post(requestUrl, command);
        }

        public GridRelato GetGridRelato()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/GetGridRelato/"));
            return Get<GridRelato>(requestUrl);
        }

        #endregion

        #region Methods

        public RelatoDto GetRelatoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/GetRelatoById/{id}"));
            return Get<RelatoDto>(requestUrl);
        }
        

        #endregion

    }
}