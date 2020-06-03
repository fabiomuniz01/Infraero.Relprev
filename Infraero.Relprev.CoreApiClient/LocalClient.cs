using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceLocal = "Local";

        #region Main Methods

        public Task<long> CreateLocal(CreateLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/CreateLocal"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateLocal(UpdateLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/UpdateLocal"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteLocal(DeleteLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/DeleteLocal"));
            return Post(requestUrl, command);
        }

        public GridLocal GetGridLocal()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/GetGridLocal"));
            return Get<GridLocal>(requestUrl);
        }

        public List<LocalDto> GetLocalAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/GetLocalAll/"));
            return Get<List<LocalDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public LocalDto GetLocalById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/GetLocalById/{id}"));
            return Get<LocalDto>(requestUrl);
        }

        public List<LocalDto> GetLocalByUnidade(int IdUnidade)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceLocal}/GetLocalByUnidade/{IdUnidade}"));
            return Get<List<LocalDto>>(requestUrl);
        }
        #endregion

    }
}