using System.Threading.Tasks;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.CreateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.DeleteResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Commands.UpdateResponsavelTecnico;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IResponsavelTecnicoClient
    {
        long CreateResponsavelTecnico(CreateResponsavelTecnicoCommand command);
        GridResponsavelTecnico GetGridResponsavelTecnico();
        ResponsavelTecnicoDto GetResponsavelTecnicoById(int id);
        bool UpdateResponsavelTecnico(UpdateResponsavelTecnicoCommand command);
        bool DeleteResponsavelTecnico(DeleteResponsavelTecnicoCommand id);
    }
}
