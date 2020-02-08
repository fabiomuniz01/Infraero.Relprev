using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.DeleteSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceSubLocal = "SubLocal";

        public Task<long> CreateSubLocal(CreateSubLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubLocal}/CreateSubLocal"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateSubLocal(UpdateSubLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubLocal}/UpdateSubLocal"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteSubLocal(DeleteSubLocalCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubLocal}/DeleteSubLocal"));
            return Post(requestUrl, command);
        }
        
        public GridSubLocal GetGridSubLocal()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubLocal}/GetGridSubLocal"));
            return  Get<GridSubLocal>(requestUrl);
        }

        public SubLocalDto GetSubLocalById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceSubLocal}/GetSubLocalById/{id}"));
            return Get<SubLocalDto>(requestUrl);
        }
    }
}
