using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Usuario.Queries.GetUsuarios
{
    public class GridUsuario : ManagerMainGrid<UsuarioDto>
    {
        public IEnumerable<UsuarioDto> aaData { get; set; }
    }
}
