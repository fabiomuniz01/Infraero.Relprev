using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos
{
    public class GridAtribuicaoRelato : ManagerMainGrid<AtribuicaoRelatoDto>
    {
        public IEnumerable<AtribuicaoRelatoDto> aaData { get; set; }
    }
}
