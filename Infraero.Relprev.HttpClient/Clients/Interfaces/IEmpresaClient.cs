using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresas.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresas.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IEmpresaClient
    {
        Task<long> CreateEmpresa(CreateEmpresaCommand command);
        GridEmpresa GetGridEmpresa();
        EmpresaDto GetEmpresaById(int id);
        bool UpdateEmpresa(UpdateEmpresaCommand command);
        bool DeleteEmpresa(int id);
    }
}
