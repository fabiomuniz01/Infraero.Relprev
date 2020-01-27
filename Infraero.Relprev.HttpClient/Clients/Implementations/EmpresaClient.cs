using System.Collections.Generic;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
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

        public long CreateEmpresa(CreateEmpresaCommand command)
        {
            return Post<long>($"{Resource}/CreateEmpresa", command);
        }
        public GridEmpresa GetGridEmpresa()
        {
            return Get<GridEmpresa>($"{Resource}/GetGridEmpresa");
        }

        public EmpresaDto GetEmpresaById(int id)
        {
            return Get<EmpresaDto>($"{Resource}/GetEmpresaById/{id}");
        }
        public List<EmpresaDto> GetEmpresaAll()
        {
            return Get<List<EmpresaDto>>($"{Resource}/GetEmpresaAll");
        }

        public bool UpdateEmpresa(UpdateEmpresaCommand command)
        {
            return Post<bool>($"{Resource}/UpdateEmpresa", command);
        }

        public bool DeleteEmpresa(DeleteEmpresaCommand command)
        {
            return Post<bool>($"{Resource}/DeleteEmpresa", command);
        }
    }
}
