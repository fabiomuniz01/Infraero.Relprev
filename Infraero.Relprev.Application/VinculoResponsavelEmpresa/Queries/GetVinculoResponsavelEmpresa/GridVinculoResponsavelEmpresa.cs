using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.VinculoResponsavelEmpresa.Queries.GetVinculoResponsavelEmpresa
{
    public class GridVinculoResponsavelEmpresa : ManagerMainGrid<VinculoResponsavelEmpresaDto>
    {
        public IEnumerable<VinculoResponsavelEmpresaDto> aaData { get; set; }
    }
}
