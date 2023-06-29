namespace MinimalApi.Models
{
    public class fornecedor
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string Cnpj { get; set; }
        public string? Documento { get; set; }
        public bool Ativo { get; set; }
    }
}
