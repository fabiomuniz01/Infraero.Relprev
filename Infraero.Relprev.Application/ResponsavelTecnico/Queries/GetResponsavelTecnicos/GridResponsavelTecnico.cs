using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.ResponsavelTecnicos.Queries.GetResponsavelTecnicos
{
    public class GridResponsavelTecnico : ManagerMainGrid<ResponsavelTecnicoDto>
    {
        public IEnumerable<ResponsavelTecnicoDto> aaData { get; set; }
    }
}
