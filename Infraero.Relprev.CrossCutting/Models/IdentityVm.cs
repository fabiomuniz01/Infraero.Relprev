using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Infraero.Relprev.CrossCutting.Models
{
    
        public class RegisterUsuarioVm
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }
        public class LoginUsuarioVm
        {
            public string Email { get; set; }
            [StringLength(12, ErrorMessage = "Formato de senha inválido, a senha deve conter no mínimo {0} digitos.", MinimumLength = 8)] //configurar parametro no appsetings
        public string Password { get; set; }
        }
}
