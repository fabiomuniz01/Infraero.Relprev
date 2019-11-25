using Infraero.Relprev.Application.Common.Interfaces;
using System;

namespace Infraero.Relprev.WebApi.IntegrationTests
{
    public class TestDateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
