using Infraero.Relprev.Application.Common.Interfaces;

namespace Infraero.Relprev.WebApi.IntegrationTests
{
    public class TestCurrentUserService : ICurrentUserService
    {
        public string UsuarioId => "00000000-0000-0000-0000-000000000000";
    }
}
