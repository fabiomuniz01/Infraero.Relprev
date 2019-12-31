using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class SubLocal : AuditableEntity
    {
        [Key]
        public int CodSubLocal { get; set; }
        public string DscSubLocal { get; set; }
        public int CodLocal { get; set; }
        public Local Local { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }

        //public ICollection<Relato> Relato { get; set; }
    }
}