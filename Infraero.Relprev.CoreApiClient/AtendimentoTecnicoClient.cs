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

        public Task<List<RelatoDto>> GetAtendimentoTecnico(AtendimentoTecnicoDto.AtendimentoTecnicoRequest obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceAtendimentoTecnico}/GetAtendimentoTecnico"));
            
            return PostAsync<List<RelatoDto>, AtendimentoTecnicoDto.AtendimentoTecnicoRequest>(requestUrl, obj);
            
        }

        //public Task<ResponsavelTecnicoDto> GetResponsavelByCpf(string cpf)
        //{
        //    var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
        //        $"{ResourceResponsavelTecnico}/GetResponsavelByCpf"));
        //    return PostAsync<ResponsavelTecnicoDto, string>(requestUrl, cpf);
        //}


        #endregion



    }
}