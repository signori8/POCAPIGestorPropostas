namespace POC.Models
{
    public class Documento
    {
        public int Id { get; set; }
        public int IdProposta { get; set; }
        public int TipoDocumento { get; set; }
        public string? Extensao { get; set; }
        public string? DocumentoBase64 { get; set; }

    }
}
