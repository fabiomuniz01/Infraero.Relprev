using System.Threading.Tasks;
using Infraero.Relprev.Application.SubAssunto.Commands.CreateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Commands.UpdateSubAssunto;
using Infraero.Relprev.Application.SubAssunto.Queries.GetSubAssuntos;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface ISubAssuntoClient
    {
        long CreateSubAssunto(CreateSubAssuntoCommand command);
        GridSubAssunto GetGridSubAssunto();
        SubAssuntoDto GetSubAssuntoById(int id);
        bool UpdateSubAssunto(UpdateSubAssuntoCommand command);
        bool DeleteSubAssunto(int id);
    }
}
