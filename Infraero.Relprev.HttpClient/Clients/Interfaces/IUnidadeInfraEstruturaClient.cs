using System.Collections.Generic;
using System.Threading.Tasks;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.CreateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Commands.UpdateUnidadeInfraEstrutura;
using Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IUnidadeInfraEstruturaClient
    {
        long CreateUnidadeInfraEstrutura(CreateUnidadeInfraEstruturaCommand command);
        GridUnidadeInfraEstrutura GetGridUnidadeInfraEstrutura();
        UnidadeInfraEstruturaDto GetUnidadeInfraEstruturaById(int id);
        bool UpdateUnidadeInfraEstrutura(UpdateUnidadeInfraEstruturaCommand command);
        bool DeleteUnidadeInfraEstrutura(int id);

        List<UnidadeInfraEstruturaDto> GetUnidadeInfraEstruturaAll();
    }
}
