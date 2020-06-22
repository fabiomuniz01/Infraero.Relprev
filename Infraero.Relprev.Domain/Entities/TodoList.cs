using Infraero.Relprev.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public TodoList()
        {
            Items = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<TodoItem> Items { get; set; }
    }
}
