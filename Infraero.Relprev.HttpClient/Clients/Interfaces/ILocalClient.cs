using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using System.Threading.Tasks;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface ILocalClient
    {
        Task<long> CreateLocal(CreateLocalCommand command);
        GridLocal GetGridLocal();
        LocalDto GetLocalById(int id);
        bool UpdateLocal(UpdateLocalCommand command);
        bool DeleteLocal(int id);

    }
}
