using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.Application.Assunto.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assunto.Commands.DeleteAssunto;
using Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceAssunto = "Assunto";

        #region Main Methods

        public Task<long> CreateAssunto(CreateAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/CreateAssunto"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateAssunto(UpdateAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/UpdateAssunto"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteAssunto(DeleteAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/DeleteAssunto"));
            return Post(requestUrl, command);
        }

        public GridAssunto GetGridAssunto()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/GetGridAssunto"));
            return Get<GridAssunto>(requestUrl);
        }

        public List<AssuntoDto> GetAssuntoAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/GetAssuntoAll/"));
            return Get<List<AssuntoDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public AssuntoDto GetAssuntoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAssunto}/GetAssuntoById/{id}"));
            return Get<AssuntoDto>(requestUrl);
        }

        #endregion

    }
}