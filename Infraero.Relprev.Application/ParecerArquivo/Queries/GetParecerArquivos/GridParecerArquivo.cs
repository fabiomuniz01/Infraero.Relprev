using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos
{
    public class GridParecerArquivo: ManagerMainGrid<ParecerArquivoDto>
    {
        public IEnumerable<ParecerArquivoDto> aaData { get; set; }
}
}
