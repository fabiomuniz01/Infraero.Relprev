using System.Threading.Tasks;
using Infraero.Relprev.Application.Usuarios.Commands.CreateUsuario;
using Infraero.Relprev.Application.Usuarios.Commands.UpdateUsuario;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Infraero.Relprev.CrossCutting.Models;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IUsuarioClient
    {
        Task<long> CreateUsuario(CreateUsuarioCommand command);
        GridUsuario GetGridUsuario();
        UsuarioDto GetUsuarioById(int id);
        bool UpdateUsuario(UpdateUsuarioCommand command);
        bool DeleteUsuario(int id);
    }
}
