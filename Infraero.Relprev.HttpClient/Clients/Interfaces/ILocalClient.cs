using System.Collections.Generic;
using Infraero.Relprev.Application.Local.Commands.CreateLocal;
using Infraero.Relprev.Application.Local.Commands.UpdateLocal;
using Infraero.Relprev.Application.Local.Queries.GetLocals;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Local.Commands.DeleteLocal;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface ILocalClient
    {
        long CreateLocal(CreateLocalCommand command);
        GridLocal GetGridLocal();
        LocalDto GetLocalById(int id);
        bool UpdateLocal(UpdateLocalCommand command);
        bool DeleteLocal(DeleteLocalCommand command);
        List<LocalDto> GetLocalAll();
    }
}
