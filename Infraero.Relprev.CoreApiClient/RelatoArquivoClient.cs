using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using Infraero.Relprev.Application.RelatoArquivo.Commands.DeleteRelatoArquivo;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceRelatoArquivo = "RelatoArquivo";

        #region Main Methods

        public Task<long> CreateRelatoArquivo(CreateRelatoArquivoCommand command)
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

        public List<RelatoArquivoDto> GetGridRelatoArquivo()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetGridRelatoArquivo"));
            return Get<List<RelatoArquivoDto>>(requestUrl);
        }

        public List<RelatoArquivoDto> GetRelatoArquivoAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetRelatoArquivoAll/"));
            return Get<List<RelatoArquivoDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public RelatoArquivoDto GetRelatoArquivoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceRelatoArquivo}/GetRelatoArquivoById/{id}"));
            return Get<RelatoArquivoDto>(requestUrl);
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