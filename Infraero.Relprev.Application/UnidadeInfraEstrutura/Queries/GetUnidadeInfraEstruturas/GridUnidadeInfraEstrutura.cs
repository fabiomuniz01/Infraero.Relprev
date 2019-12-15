using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class GridUnidadeInfraEstrutura : ManagerMainGrid<UnidadeInfraEstruturaDto>
    {
        public IEnumerable<UnidadeInfraEstruturaDto> aaData { get; set; }
    }
}
