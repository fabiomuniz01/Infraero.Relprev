using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;
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

        public long Create(EmpresaVm obj)
        {
            return Post<long>($"{Resource}/Create", obj);
        }
    }
}
