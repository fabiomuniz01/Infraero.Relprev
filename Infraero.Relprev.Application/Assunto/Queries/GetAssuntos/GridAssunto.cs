using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Assuntos.Queries.GetAssuntos
{
    public class GridUnidadeInfraEstrutura : ManagerMainGrid<UnidadeInfraEstruturaDto>
    {
        public IEnumerable<UnidadeInfraEstruturaDto> aaData { get; set; }
    }
}
