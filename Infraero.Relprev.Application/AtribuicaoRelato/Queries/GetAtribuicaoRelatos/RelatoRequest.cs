namespace Infraero.Relprev.Application.Relato.Queries.GetRelatos
{
    public class RelatoRequest
    {
        public string NumRelato { get; set; }
        public string CodResponsavelTecnico { get; set; }
        public string FlgStatusRelato { get; set; }
        public string DtInicio { get; set; }
        public string DtFim { get; set; }
    }
}
