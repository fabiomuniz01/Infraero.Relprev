using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class GridRelato : ManagerMainGrid<RelatoDto>
    {
        public IEnumerable<RelatoDto> aaData { get; set; }
    }
}
