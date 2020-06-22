using Infraero.Relprev.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraero.Relprev.Domain.Entities
{
    public class TodoItem : AuditableEntity
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public bool Done { get; set; }

        public DateTime? Reminder { get; set; }


        public TodoList List { get; set; }
    }
}
