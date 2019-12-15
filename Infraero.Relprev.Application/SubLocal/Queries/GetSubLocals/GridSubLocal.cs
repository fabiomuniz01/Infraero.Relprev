using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.SubLocal.Queries.GetSubLocals
{
    public class GridSubLocal : ManagerMainGrid<SubLocalDto>
    {
        public IEnumerable<SubLocalDto> aaData { get; set; }
    }
}
