using Infraero.Relprev.Domain.Common;
using Infraero.Relprev.Domain.Enums;
using System;

namespace Infraero.Relprev.Domain.Entities
{
    public class Usuario : AuditableEntity
    {
        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public bool Done { get; set; }

        public DateTime? Reminder { get; set; }

        public PriorityLevel Priority { get; set; }


    }
}
