using System;
using System.Collections.Generic;
using System.Threading.Tasks;
//using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
//using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        public string Resource = "UnidadeInfraEstrutura";

        public async Task<GridUnidadeInfraEstrutura> GetGridUnidadeInfraEstrutura()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{Resource}/GetGridUnidadeInfraEstrutura"));
            return await GetAsync<GridUnidadeInfraEstrutura>(requestUrl);
        }

        //public async Task<Message<UsersModel>> SaveUser(UsersModel model)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        "User/SaveUser"));
        //    return await PostAsync<UsersModel>(requestUrl, model);
        //}
    }
}
