using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Application.Common.Interfaces
{
    public interface IApplicationDbContextPg
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
