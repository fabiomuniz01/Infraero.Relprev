using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.AtendimentoTecnico.Queries.GetAtendimentoTecnico;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Newtonsoft.Json;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceAtendimentoTecnico = "AtendimentoTecnico";

        #region Main Methods

        public Task<List<RelatoDto>> GetAtendimentoTecnico(AtendimentoRequest obj)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtendimentoTecnico}/GetAtendimentoTecnico"));
            
            return PostAsync<List<RelatoDto>, AtendimentoRequest>(requestUrl, obj);
        }

        #endregion



    }
}