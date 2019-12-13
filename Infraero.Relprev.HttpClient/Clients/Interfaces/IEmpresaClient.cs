using Infraero.Relprev.Application.Empresas.Queries.GetEmpresas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.HttpClient.Clients.Interfaces
{
    public interface IEmpresaClient
    {
        //long Create(EmpresaVm obj);
        long Create(EmpresaVm empresaVm);
    }
}
