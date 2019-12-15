using System.Collections.Generic;
using Infraero.Relprev.Application.Grid;

namespace Infraero.Relprev.Application.Empresa.Queries.GetEmpresas
{
    public class GridEmpresa : ManagerMainGrid<EmpresaDto>
    {
        public IEnumerable<EmpresaDto> aaData { get; set; }
    }
}
