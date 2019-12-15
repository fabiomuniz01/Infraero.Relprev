using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Local.Queries.GetLocals
{
    public class GridLocal : ManagerMainGrid<LocalDto>
    {
        public IEnumerable<LocalDto> aaData { get; set; }
    }
}
