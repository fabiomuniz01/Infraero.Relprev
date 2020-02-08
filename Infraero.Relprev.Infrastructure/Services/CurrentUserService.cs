using System.Security.Claims;
using Infraero.Relprev.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infraero.Relprev.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UsuarioId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UsuarioId { get; }
    }
}
