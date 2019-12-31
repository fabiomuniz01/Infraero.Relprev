using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Local : AuditableEntity
    {
        [Key]
        public int CodLocal { get; set; }
        public string DscLocal { get; set; }
        public string SigLocal { get; set; }
        public string EndLocal { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }

        [ForeignKey("CodLocal")]
        public ICollection<SubLocal> SubLocalList { get; set; }

        public int CodUnidadeInfraestrutura { get; set; }
        public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }


        //[ForeignKey("CodUnidadeInfraestrutura")]
        //public virtual ICollection<UnidadeInfraestrutura> UnidadeInfraestrutura { get; set; }



        public virtual ICollection<Ambiente> Ambiente { get; set; }
        public virtual ICollection<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
        public virtual ICollection<EmpresaLocalidade> EmpresaLocalidade { get; set; }
        public virtual ICollection<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<UsuarioLocalidade> UsuarioLocalidade { get; set; }
    }
}
