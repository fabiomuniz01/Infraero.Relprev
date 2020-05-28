using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using Infraero.Relprev.Application.RelatoArquivo.Commands.DeleteRelatoArquivo;


namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceRelatoArquivo = "RelatoArquivo";

        #region Main Methods

        public Task<long> CreateArquivo(CreateRelatoArquivoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/CreateRelatoArquivo"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteRelatoArquivo(DeleteRelatoArquivoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/DeleteRelatoArquivo"));
            return Post(requestUrl, command);
        }


        public GridRelatoArquivo GetGridRelatoArquivo()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetGridRelatoArquivo"));
            return Get<GridRelatoArquivo>(requestUrl);
        }

        public List<RelatoArquivoDto> GetRelatoArquivoAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetRelatoArquivoAll/"));
            return Get<List<RelatoArquivoDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public List<RelatoArquivoDto> GetRelatoArquivoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetRelatoArquivoById/{id}"));
            return Get<List<RelatoArquivoDto>>(requestUrl);
        }

        public List<RelatoArquivoDto> GetRelatoArquivoByIdRelato(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetRelatoArquivoByIdRelato/{id}"));
            return Get<List<RelatoArquivoDto>>(requestUrl);
        }

        #endregion

    }
}