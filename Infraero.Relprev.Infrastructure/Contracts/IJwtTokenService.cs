using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Infrastructure.Contracts
{
    public interface IJwtTokenService
    {
        string GenerateToken();
        bool ValidateToken(string token);
    }
}
