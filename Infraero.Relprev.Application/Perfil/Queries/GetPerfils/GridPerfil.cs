using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Perfil.Queries.GetPerfils
{
    public class GridPerfil : ManagerMainGrid<PerfilDto>
    {
        public IEnumerable<PerfilDto> aaData { get; set; }
    }
}
