using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Parecer.Queries.GetParecer
{
    public class GridParecer : ManagerMainGrid<ParecerDto>
    {
        public IEnumerable<ParecerDto> aaData { get; set; }
    }
}
