using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios;
using Infraero.Relprev.Domain.Enums;

namespace Infraero.Relprev.Application.Usuarios.Queries.GetUsuarios
{
    public class UsuarioVm
    {
        public List<UsuarioDto> Lists { get; set; }
    }
}
