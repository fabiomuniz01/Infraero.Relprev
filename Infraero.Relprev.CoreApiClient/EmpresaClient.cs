using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.RelatoArquivo.Commands.CreateRelatoArquivo;
using System;

namespace Infraero.Relprev.CoreApiClient
{
    public partial class ApiClient
    {
        private const string ResourceEmpresa = "Empresa";

        #region Main Methods

        public Task<long> CreateEmpresa(CreateEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/CreateEmpresa"));
            return Post(requestUrl, command);
        }
        public Task<long> UpdateEmpresa(UpdateEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/UpdateEmpresa"));
            return Post(requestUrl, command);
        }

        public Task<long> DeleteEmpresa(DeleteEmpresaCommand command)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/DeleteEmpresa"));
            return Post(requestUrl, command);
        }

        public GridEmpresa GetGridEmpresa()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetGridEmpresa"));
            return Get<GridEmpresa>(requestUrl);
        }

        public List<EmpresaDto> GetEmpresaAll()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetEmpresaAll/"));
            return Get<List<EmpresaDto>>(requestUrl);
        }

        #endregion

        #region Methods

        public EmpresaDto GetEmpresaById(int id)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetEmpresaById/{id}"));
            return Get<EmpresaDto>(requestUrl);
        }
        public Task<EmpresaDto> GetEmpresaByCnpj (string cnpj)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,
                $"{ResourceEmpresa}/GetEmpresaByCnpj"));
            return PostAsync<EmpresaDto,string>(requestUrl, cnpj);
        }

        //public Task CreateRelatoArquivo(CreateRelatoArquivoCommand commandRelatoArquivo)
        //{
        //    throw new NotImplementedException();
        //}



        #endregion

    }
}