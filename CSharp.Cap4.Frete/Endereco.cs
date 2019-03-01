namespace CSharp.Cap4.Frete
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public Municipio Municipio { get; set; }
    }
}