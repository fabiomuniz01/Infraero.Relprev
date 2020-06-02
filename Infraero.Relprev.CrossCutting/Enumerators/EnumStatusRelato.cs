﻿using System.ComponentModel;

namespace Infraero.Relprev.CrossCutting.Enumerators
{
    public enum EnumStatusRelato
    {
        [Description("Não Iniciado")]
        NaoIniciado = 0,
        [Description("Cancelado")]
        Cancelado = 1,
        [Description("Aguardando Parecer Técnico")]
        AguardandoParecerTecnico = 2,
        [Description("Aguardando Resposta")]
        AguardandoResposta = 3,
        [Description("Aguardando Complemento")]
        AguardandoComplemento = 4,
        [Description("Finalizado")]
        Finalizado = 5
    }
}
