using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.DeleteSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceSubAssunto = "SubAssunto";

        #region Main Methods

        public Task<long> CreateSubAssunto(CreateSubAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/CreateSubAssunto"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateSubAssunto(UpdateSubAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/UpdateSubAssunto"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteSubAssunto(DeleteSubAssuntoCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/DeleteSubAssunto"));
            return Post(requestUrl, command);
        }

        public GridSubAssunto GetGridSubAssunto()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/GetGridSubAssunto"));
            return Get<GridSubAssunto>(requestUrl);
        }

        public List<SubAssuntoDto> GetSubAssuntoAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/GetSubAssuntoAll/"));
            return Get<List<SubAssuntoDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public SubAssuntoDto GetSubAssuntoById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubAssunto}/GetSubAssuntoById/{id}"));
            return Get<SubAssuntoDto>(requestUrl);
        }

        #endregion
        
    }
}