using System.Threading.Tasks;
using Infraero.Relprev.Application.SubLocal.Commands.CreateSubLocal;
using Infraero.Relprev.Application.SubLocal.Commands.UpdateSubLocal;
using Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface ISubLocalClient
    {
        long CreateSubLocal(CreateSubLocalCommand command);
        GridSubLocal GetGridSubLocal();
        SubLocalDto GetSubLocalById(int id);
        bool UpdateSubLocal(UpdateSubLocalCommand command);
        bool DeleteSubLocal(int id);
    }
}
