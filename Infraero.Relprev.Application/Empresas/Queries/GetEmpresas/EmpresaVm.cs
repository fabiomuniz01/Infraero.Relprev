using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Infraero.Relprev.Domain.Enums;

namespace Infraero.Relprev.Application.Empresas.Queries.GetEmpresas
{
    public class EmpresaVm
    {
        public IList<PriorityLevelDto> PriorityLevels =
            Enum.GetValues(typeof(PriorityLevel))
                .Cast<PriorityLevel>()
                .Select(p => new PriorityLevelDto { Value = (int)p, Name = p.ToString() })
                .ToList();

        public List<EmpresaDto> Lists { get; set; }
    }
}
