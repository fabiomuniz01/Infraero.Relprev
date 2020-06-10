using System.ComponentModel;

namespace Infraero.Relprev.CrossCutting.Enumerators
{
    public enum EnumSituacaoAtribuicao
    {
        [Description("Ocorrência Atribuída")]
        OcorrenciaAtribuida = 0,
        [Description("Ocorrência Removida")]
        OcorrenciaRemovida = 1
    }
}
