using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnicos.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnicos.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnicos.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IResponsavelTecnicoClient
    {
        Task<long> CreateResponsavelTecnico(CreateResponsavelTecnicoCommand command);
        GridResponsavelTecnico GetGridResponsavelTecnico();
        ResponsavelTecnicoDto GetResponsavelTecnicoById(int id);
        bool UpdateResponsavelTecnico(UpdateResponsavelTecnicoCommand command);
        bool DeleteResponsavelTecnico(int id);
    }
}
