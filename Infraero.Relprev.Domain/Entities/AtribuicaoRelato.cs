﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class AtribuicaoRelato : AuditableEntity
    {
        [Key]
        public int CodAtribuicaoRelato { get; set; }
        public int CodResponsavelTecnicoSgso { get; set; }
        public int CodRelato { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
        public string DscParecerTecnico { get; set; }
        public int CodUsuarioAtribuidor { get; set; }
        public DateTime DthAtribuicao { get; set; }
        public DateTime? DthFimAtendimento { get; set; }
        public string ObsAtribuicao { get; set; }
        [ForeignKey("CodResponsavelTecnicoSgso")]
        public Usuario ResponsavelTecnicoSgso { get; set; }
        [ForeignKey("CodRelato")]
        public Relato Relato { get; set; }
    }
}
