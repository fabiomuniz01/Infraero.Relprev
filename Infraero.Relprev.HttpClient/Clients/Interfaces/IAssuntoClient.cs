using System.Threading.Tasks;
using Infraero.Relprev.Application.Assunto.Commands.CreateAssunto;
using Infraero.Relprev.Application.Assunto.Commands.UpdateAssunto;
using Infraero.Relprev.Application.Assunto.Queries.GetAssuntos;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IAssuntoClient
    {
        Task<long> CreateAssunto(CreateAssuntoCommand command);
        GridAssunto GetGridAssunto();
        AssuntoDto GetAssuntoById(int id);
        bool UpdateAssunto(UpdateAssuntoCommand command);
        bool DeleteAssunto(int id);
    }
}
