using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class AnexoRelato : AuditableEntity
    {
        [Key]
        public int CodAnexo { get; set; }
        public int CodRelato { get; set; }
        public int? CodAtribuicaoRelato { get; set; }
        public byte[] BinAnexo { get; set; }
        public string TipFormatoAnexo { get; set; }
        public DateTime DthRegistro { get; set; }
        public string DscAnexo { get; set; }

        public virtual AtribuicaoRelato CodAtribuicaoRelatoNavigation { get; set; }
        public virtual Relato CodRelatoNavigation { get; set; }
    }
}
