using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Parecer.Queries.GetParecer;
using Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos;

using Infraero.Relprev.Application.Parecer.Commands.CreateParecer;
using Infraero.Relprev.Application.Parecer.Commands.CompleteParecer;

using System;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceParecer = "Parecer";
        
        #region Main Methods

        public Task<long> CreateParecer(CreateParecerCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceParecer}/CreateParecer"));
            return Post(requestUrl, command);
        }
        public Task<long> CompletePàrecer(CompleteParecerCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceParecer}/CompletePàrecer"));
            return Post(requestUrl, command);
        }
       
        //public GridParecer GetGridParecer()
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        $"{ResourceParecer}/GetGridParecer/"));
        //    return Get<GridParecer>(requestUrl);
        //}

        #endregion

        #region Methods

        public List<ParecerDto> GetParecerAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceParecer}/GetParecerAll/"));
            return Get<List<ParecerDto>>(requestUrl);
        }

        public ParecerDto GetParecerById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceParecer}/GetParecerById/{id}"));
            return Get<ParecerDto>(requestUrl);
        }
        
        public List<ParecerDto> GetParecerByStatus(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceParecer}/GetParecerByStatus/{id}"));
            return Get<List<ParecerDto>>(requestUrl);
        }

        #endregion

    }
}