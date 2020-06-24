using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Commands.UpdateRelato;
using Infraero.Relprev.Application.Relato.Commands.CancelRelato;
using Infraero.Relprev.Application.Relato.Commands.ClassificarRelato;

using Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos;
using Infraero.Relprev.Application.Relato.Commands.FinalizeRelato;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceRelato = "Relato";
        private const string ResourceAtribuicao = "AtribuicaoRelato";

        #region Main Methods

        public Task<long> CreateRelato(CreateRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/CreateRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateRelatoAtribuido(UpdateRelatoAtribuidoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/UpdateRelatoAtribuido"));
            return Post(requestUrl, command);
        }
        public Task<long> ClassificarRelato(ClassificarRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/ClassificarRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> CancelRelato(CancelRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/CancelRelato"));
            return Post(requestUrl, command);
        }
        public Task<long> FinalizeRelato(FinalizeRelatoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/FinalizeRelato"));
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
        
        public RelatoDto GetRelatoByNumRelato(string id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelato}/GetRelatoByNumRelato/{id}"));
            return Get<RelatoDto>(requestUrl);
        }
        #endregion

    }
}