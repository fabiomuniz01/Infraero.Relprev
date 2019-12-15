using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Assunto.Queries.GetAssuntos
{
    public class GridAssunto : ManagerMainGrid<AssuntoDto>
    {
        public IEnumerable<AssuntoDto> aaData { get; set; }
    }
}
