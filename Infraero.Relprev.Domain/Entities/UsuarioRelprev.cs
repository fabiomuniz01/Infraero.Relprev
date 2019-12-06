using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class UsuarioRelprev : AuditableEntity
    {
        public UsuarioRelprev()
        {
            AtribuicaoRelato = new HashSet<AtribuicaoRelato>();
            Evento = new HashSet<Evento>();
            HistoricoRelato = new HashSet<HistoricoRelato>();
            PerfilUsuario = new HashSet<PerfilUsuario>();
            Relato = new HashSet<Relato>();
            UsuarioLocalidade = new HashSet<UsuarioLocalidade>();
        }

        [Key]
        public int CodUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string DscLogin { get; set; }
        public string DscSenha { get; set; }
        public DateTime DthRegistro { get; set; }
        public string EndEmail { get; set; }
        public int QtdTentativasIncorretas { get; set; }
        public string FlgPrimeiroAcesso { get; set; }
        public string FlgUsuarioBloqueado { get; set; }

        public virtual ICollection<AtribuicaoRelato> AtribuicaoRelato { get; set; }
        public virtual ICollection<Evento> Evento { get; set; }
        public virtual ICollection<HistoricoRelato> HistoricoRelato { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual ICollection<Relato> Relato { get; set; }
        public virtual ICollection<UsuarioLocalidade> UsuarioLocalidade { get; set; }
    }
}
