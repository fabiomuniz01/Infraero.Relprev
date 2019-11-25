using Infraero.Relprev.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios
{
    public class UsuariosVm
    {
        public IList<PriorityLevelDto> PriorityLevels =
            Enum.GetValues(typeof(PriorityLevel))
                .Cast<PriorityLevel>()
                .Select(p => new PriorityLevelDto { Value = (int)p, Name = p.ToString() })
                .ToList();
        public IList<UsuarioDto> Lists { get; set; }
    }
}
