using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos
{
    public class GridRelatoArquivo: ManagerMainGrid<RelatoArquivoDto>
    {
        public IEnumerable<RelatoArquivoDto> aaData { get; set; }
}
}
