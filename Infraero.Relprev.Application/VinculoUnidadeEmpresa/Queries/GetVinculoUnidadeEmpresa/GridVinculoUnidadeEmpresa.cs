using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.VinculoUnidadeEmpresa.Queries.GetVinculoUnidadeEmpresa
{
    public class GridVinculoUnidadeEmpresa : ManagerMainGrid<VinculoUnidadeEmpresaDto>
    {
        public IEnumerable<VinculoUnidadeEmpresaDto> aaData { get; set; }
    }
}
