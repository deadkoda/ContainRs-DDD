namespace ContainRs.Vendas.Propostas
{
    public class Endereco
    {
        public required string CEP { get; set; }
        public string? Referencias { get; set; }
        public double? Latitudes { get; set; }
        public double? Longitudes { get; set; }
    }
}
