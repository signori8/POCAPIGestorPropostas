namespace POC.Models;

public class Proposta
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public string? Parceiro { get; set; }
    public string? Estabelecimento { get; set; }
    public int Produto { get; set; }
    public Double ValorSolicitado { get; set; }
    public int Prazo { get; set; }
    public DateTime PrimeiroVencimento { get; set; }
    public string? Cpf { get; set; }
    public string? Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Cep {get; set; }
    public string? Cidade { get; set; }
    public string? Endereco { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? NomeMae { get; set; }
    public string? Profissao { get; set; }
    public Double Renda { get; set; }
   // public List<Documento>? Documentos { get; set; }


}
