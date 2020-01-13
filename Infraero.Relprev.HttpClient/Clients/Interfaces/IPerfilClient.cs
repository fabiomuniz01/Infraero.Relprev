using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Perfil.Commands.CreatePerfil;
using Infraero.Relprev.Application.Perfil.Commands.DeletePerfil;
using Infraero.Relprev.Application.Perfil.Commands.UpdatePerfil;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;
using Infraero.Relprev.Application.Perfil.Queries.GetPerfils;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IPerfilClient
    {
        int CreatePerfil(CreatePerfilCommand command);
        GridPerfil GetGridPerfil();
        PerfilDto GetPerfilById(int id);
        bool UpdatePerfil(UpdatePerfilCommand command);
        bool DeletePerfil(DeletePerfilCommand command);
        List<PerfilDto> GetPerfilAll();
    }
}
