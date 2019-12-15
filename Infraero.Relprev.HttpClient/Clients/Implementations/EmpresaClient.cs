using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresas.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.HttpClient.Http;

namespace Infraero.Relprev.HttpClient.Clients.Implementations
{
    public class EmpresaClient : RestClientAPI, IEmpresaClient
    {
        public string Resource = "Empresa";

        /// <summary>
        /// Constructor
        /// </summary>
        public EmpresaClient(string endpoint, IClientSDK httpSDKClient) : base(endpoint, httpSDKClient)
        {
        }

        public Task<long> CreateEmpresa(CreateEmpresaCommand command)
        {
            return PostAsync<long>($"{Resource}/CreateEmpresa", command);
        }
        public GridEmpresa GetGridEmpresa()
        {
            return Get<GridEmpresa>($"{Resource}/GetGridEmpresa");
        }

        public EmpresaDto GetEmpresaById(int id)
        {
            return Get<EmpresaDto>($"{Resource}/GetEmpresaById/{id}");
        }

        public bool UpdateEmpresa(UpdateEmpresaCommand command)
        {
            return Post<bool>($"{Resource}/UpdateEmpresa", command);
        }

        public bool DeleteEmpresa(int id)
        {
            return Post<bool>($"{Resource}/DeleteEmpresa", id);
        }
    }
}
