using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class Empresa : AuditableEntity
    {
        public Empresa()
        {
            ContratoUtilizacaoSistema = new HashSet<ContratoUtilizacaoSistema>();
            EmpresaLocalidade = new HashSet<EmpresaLocalidade>();
            UnidadeInfraestrutura = new HashSet<UnidadeInfraestrutura>();
        }

        [Key]
        public int CodEmpresa { get; set; }
        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public DateTime DthRegistro { get; set; }
        public string NumTelefone { get; set; }
        //public string EndEmpresa { get; set; }
        //public string EndEmail { get; set; }
        //
        public virtual ICollection<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
        public virtual ICollection<EmpresaLocalidade> EmpresaLocalidade { get; set; }
        public virtual ICollection<UnidadeInfraestrutura> UnidadeInfraestrutura { get; set; }
    }
}
