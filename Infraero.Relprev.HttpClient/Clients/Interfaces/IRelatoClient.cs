using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Relato.Commands.CreateRelato;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IRelatoClient
    {
        long CreateRelato(CreateRelatoCommand command);
        GridRelato GetGridRelato();

    }
}
