using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infraero.Relprev.Api.Models
{
    public class IdentityVm
    {
        public class RegisterUsuarioVm
        {
            public string Email { get; set; }
            public string Senha { get; set; }
            public string ConfirmaSenha { get; set; }
        }
        public class LoginUsuarioVm
        {
            public string Email { get; set; }
            public string Senha { get; set; }
            public string ConfirmaSenha { get; set; }
        }
    }
}
