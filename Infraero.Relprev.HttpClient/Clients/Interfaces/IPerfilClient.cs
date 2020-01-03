using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IPerfilClient
    {
        List<PerfilDto> GetPerfilAll();
    }
}
