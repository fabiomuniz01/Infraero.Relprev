using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Empresa.Commands.CreateEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.DeleteEmpresa;
using Infraero.Relprev.Application.Empresa.Commands.UpdateEmpresa;
using Infraero.Relprev.Application.Empresa.Queries.GetEmpresas;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IEmpresaClient
    {
        long CreateEmpresa(CreateEmpresaCommand command);
        GridEmpresa GetGridEmpresa();
        EmpresaDto GetEmpresaById(int id);
        bool UpdateEmpresa(UpdateEmpresaCommand command);
        bool DeleteEmpresa(DeleteEmpresaCommand command);
        List<EmpresaDto> GetEmpresaAll();
    }
}
