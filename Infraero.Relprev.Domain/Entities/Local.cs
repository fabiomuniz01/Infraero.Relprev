using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Local : AuditableEntity
    {
        public Local()
        {
            Ambiente = new HashSet<Ambiente>();
            ContratoUtilizacaoSistema = new HashSet<ContratoUtilizacaoSistema>();
            EmpresaLocalidade = new HashSet<EmpresaLocalidade>();
            EmpresaResponsavelTecnico = new HashSet<EmpresaResponsavelTecnico>();
            Relato = new HashSet<Relato>();
            UsuarioLocalidade = new HashSet<UsuarioLocalidade>();
        }

        [Key]
        public int CodLocalidade { get; set; }
        public string DscLocalidade { get; set; }
        public string SigLocalidade { get; set; }
        public string EndLocalidade { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }

        public virtual ICollection<Ambiente> Ambiente { get; set; }
        public virtual ICollection<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
        public virtual ICollection<EmpresaLocalidade> EmpresaLocalidade { get; set; }
        public virtual ICollection<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<UsuarioLocalidade> UsuarioLocalidade { get; set; }
    }
}
