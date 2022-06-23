namespace Projeto_POO.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private string Telefone{ get; set; }
       

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
         public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
         public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}