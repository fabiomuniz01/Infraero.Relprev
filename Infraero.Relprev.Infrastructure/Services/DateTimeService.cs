using Infraero.Relprev.Application.Common.Interfaces;
using System;

namespace Infraero.Relprev.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }

    
}
